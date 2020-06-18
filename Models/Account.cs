using System;

namespace HayEquipo.Models
{
    public abstract class Account
    {
        private string mail;
        private string password;

        public string Id { get; private set; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }

        public Account()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}