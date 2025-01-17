﻿using WeatherApp.Models.DTOs;
using WeatherApp.Models.Entities;

namespace WeatherApp.Interfaces
{
    public interface IEmailService
    {
        Task SendEmail(EmailMessage emailMessage);
        void EmailVerification(User user);
        void PasswordReset(string email);
    }
}