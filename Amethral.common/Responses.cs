using System;

namespace Amethral.Common.DTOs
{
    public class UserProfileResponse
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }

    public class LoginResponse
    {
        public string token; // Le JWT retourné par l'API
    }
    
    public class ErrorResponse
    {
        public string message;
    }
}