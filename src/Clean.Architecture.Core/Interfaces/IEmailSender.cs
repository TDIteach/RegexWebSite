using System.Threading.Tasks;

namespace RegexWebSite.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
