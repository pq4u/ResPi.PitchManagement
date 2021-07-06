using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResPi.PitchManagement.Application.Models.Mail;

namespace ResPi.PitchManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        public abstract Task<bool> SendEmail(Email email);
    }
}
