﻿using System.ComponentModel.DataAnnotations;

namespace Shopping_Tutorial.Models.ViewModels
{
    public class LoginViewModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập user name")]
        public string Username { get; set; }

        [DataType(DataType.Password), Required(ErrorMessage = "Vui lòng nhập password")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}