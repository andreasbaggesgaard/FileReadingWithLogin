using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csharp3rdHandin
{
    [Serializable]
    public class Organizers : Person
    {
        private string requiredEmail = "@poke.dk";

        public Organizers(string alias, string name, int age, string password, string email) : base(alias, name, age, password, email)
        {
           
        }

        public override bool ChangeEmail(string checkEmail)
        {
            if (checkEmail.EndsWith(requiredEmail))
            {
                this.email = checkEmail;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public override string ToString()
        {
            return " Organizer: Alias: " + alias + ", Name: " + name + ", Age: " + age + ", Password: " + password + ", Email: " + email;
        }
    }
}