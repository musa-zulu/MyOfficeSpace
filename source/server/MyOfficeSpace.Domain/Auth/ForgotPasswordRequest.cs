﻿using System.ComponentModel.DataAnnotations;

namespace MyOfficeSpace.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
