using System;

namespace HayEquipo.Models
{
    public class Player: Account
    {
        public Player(string mail, string password)
        {
            this.Mail = mail;
            this.Password = password;
        }
    }
}