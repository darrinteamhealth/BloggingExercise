using BloggingExercise.Interfaces;
using BloggingExercise.Models;
using EntityFramework.DataContext;
using EntityFramework.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingExercise.DataAccess
{
    public class BlogPostDataAccess
    {
        private readonly IConfiguration _config;
        private readonly IEmailService _emailservice;
        public BlogPostDataAccess(IConfiguration configuration, IEmailService emailservice)
        {
            _config = configuration;
            _emailservice = emailservice;
        }

        public async Task<List<BlogPost>> GetPosts(int offset, int limit, string sort, string sortby)
        {
            try
            {
                using (BlogPostContext bpc = new BlogPostContext())
                {
                    if (sortby == "title" && sort == "desc")
                        return (from posts in bpc.BlogPosts.OrderByDescending(a => a.Title) select posts).Skip(offset).Take(limit).ToList();
                    if (sortby == "title" && sort == "asc")
                        return (from posts in bpc.BlogPosts.OrderBy(a => a.Title) select posts).Skip(offset).Take(limit).ToList();
                    if (sortby == "body" && sort == "desc")
                        return (from posts in bpc.BlogPosts.OrderByDescending(a => a.Body) select posts).Skip(offset).Take(limit).ToList();
                    if (sortby == "body" && sort == "asc")
                        return (from posts in bpc.BlogPosts.OrderBy(a => a.Body) select posts).Skip(offset).Take(limit).ToList();
                    if (sortby == "datetime" && sort == "desc")
                        return (from posts in bpc.BlogPosts.OrderByDescending(a => a.DateTimePosted) select posts).Skip(offset).Take(limit).ToList();
                    if (sortby == "datetime" && sort == "asc")
                        return (from posts in bpc.BlogPosts.OrderBy(a => a.DateTimePosted) select posts).Skip(offset).Take(limit).ToList();
                    if (sortby == "id" && sort == "desc")
                        return (from posts in bpc.BlogPosts.OrderByDescending(a => a.Id) select posts).Skip(offset).Take(limit).ToList();
                    if (sortby == "id" && sort == "asc")
                        return (from posts in bpc.BlogPosts.OrderBy(a => a.Id) select posts).Skip(offset).Take(limit).ToList();
                    else
                        throw new Exception("Unhandled sort and sortby combination in query string. sort = asc/desc, sortby = title/body/datetime/id");

                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public async Task AddPost(BlogPost blogpost)
        {
            try
            {
                using (BlogPostContext bpc = new BlogPostContext())
                {
                    blogpost.DateTimePosted = DateTime.Now;
                    bpc.Add(blogpost);
                    await bpc.SaveChangesAsync();
                    await _emailservice.SendEmailAsync(new EmailMessage("Blog Post Successfully Added", $"Id = {blogpost.Id}"));
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
