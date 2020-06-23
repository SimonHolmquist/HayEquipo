using System;

namespace HayEquipo.Models
{
    public class Account
    {
        private int id;
        private string mail;
        private string password;

        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
    }
}