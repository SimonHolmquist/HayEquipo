using System;

namespace HayEquipo.Models
{
    public abstract class Account
    {
        private int id;
        private string mail;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
    }
}