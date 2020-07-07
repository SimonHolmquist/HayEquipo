using System;
using System.ComponentModel.DataAnnotations;

namespace HayEquipo.Models
{
    public abstract class Account
    {
        private int id;
        private string mail;
        private string password;
        [Required]
        [EmailAddressAttribute]
        public string Mail { get => mail; set => mail = value; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
    }
}