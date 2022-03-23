using BloggingExercise.Models;
using System.Threading.Tasks;

namespace BloggingExercise.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailMessage emailmessage);
    }
}
