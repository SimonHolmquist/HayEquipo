using System;

namespace HayEquipo.Models
{
    public class Account
    {
        private int id;
        private int mail;
        private string password;

        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
    }
}