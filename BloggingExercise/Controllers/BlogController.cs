using BloggingExercise.DataAccess;
using BloggingExercise.Interfaces;
using BloggingExercise.Models;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace BloggingExercise.Controllers
{
    public class BlogController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IEmailService _emailservice;
        private readonly BlogPostDataAccess _data;
        public BlogController(IConfiguration configuration, IEmailService emailservice, BlogPostDataAccess dataaccess)
        {
            _config = configuration;
            _emailservice = emailservice;
            _data = dataaccess;
        }

        [Route("TestEmail/{testsubject}/{testbody}")]
        //Test endpoint for email
        public async Task<IActionResult> SendTestEmail(string testsubject, string testbody)
        {
            try
            {
                await _emailservice.SendEmailAsync(new EmailMessage(testsubject, testbody));
                return Ok(200);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [Route("GetPosts")]
        [HttpGet]
        //Example GetPosts route uses query string as follows:
        //GetPosts?sort=asc&sortby=id&offset=0&limit=1000
        //Supported sort = asc/desc
        //Supported sortby = title/body/datetime/id
        public async Task<IActionResult> GetPosts()
        {
            int offset = 0;
            int limit = 1000;
            string sort = "asc";
            string sortby = "id";

            if (!string.IsNullOrEmpty(HttpContext.Request.Query["offset"]) && Convert.ToInt32(HttpContext.Request.Query["offset"]) >= 0)
                offset = Convert.ToInt32(HttpContext.Request.Query["offset"]);
            if (!string.IsNullOrEmpty(HttpContext.Request.Query["limit"]))
                limit = Convert.ToInt32(HttpContext.Request.Query["limit"]);
            if (!string.IsNullOrEmpty(HttpContext.Request.Query["sort"]) && Convert.ToString(HttpContext.Request.Query["sort"]).ToLowerInvariant() == "desc")
                sort = Convert.ToString(HttpContext.Request.Query["sort"]).ToLowerInvariant();
            if (!string.IsNullOrEmpty(HttpContext.Request.Query["sortby"]) && (
                Convert.ToString(HttpContext.Request.Query["sortby"]).ToLowerInvariant() == "title" ||
                Convert.ToString(HttpContext.Request.Query["sortby"]).ToLowerInvariant() == "body" ||
                Convert.ToString(HttpContext.Request.Query["sortby"]).ToLowerInvariant() == "datetime"
                ))
                sortby = Convert.ToString(HttpContext.Request.Query["sortby"]).ToLowerInvariant();

            try
            {
                var x = await _data.GetPosts(offset, limit, sort, sortby);
                return Ok(x);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [Route("AddPost")]
        [HttpPost]
        //Sample Post Body JSON:
        //{"title":"<title>","body":"<body>","authorId":1,"subjectId":5}
        public async Task<IActionResult> AddPost([FromBody] BlogPost post)
        {
            try
            {
                await _data.AddPost(post);
                return Ok(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
