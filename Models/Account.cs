using System;

namespace HayEquipo.Models
{
    public class Account
    {
        private int mail;
        private string password;

        public int Id { get; set; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
    }
}