﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Sat.Recruitment.Contracts
{
    public class UserDTO
    {
        [Required(ErrorMessage = "The name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The Adress is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "The phone is required")]
        public string Phone { get; set; }
        public string UserType { get; set; }
        public string Money { get; set; }
    }
}
