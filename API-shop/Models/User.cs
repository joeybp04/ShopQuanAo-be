﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_shop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }

    public class CreateUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UpdateUser
    {

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
