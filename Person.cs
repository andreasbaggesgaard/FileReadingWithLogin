using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csharp3rdHandin
{
    [Serializable]
    public abstract class Person
    {
        protected string alias;
        protected string name;
        protected int age;
        protected string password;
        protected string email;

        public Person(string alias, string name, int age, string password, string email)
        {
            this.alias = alias;
            this.name = name;
            this.age = age;
            this.password = password;
            this.email = email;
        }

        public virtual bool ChangeEmail(string newEmail)
        {
              this.email = newEmail;
            return true;
        }

        public override string ToString()
        {
            return "Alias: " + alias + ", Name: " + name + ", Age: " + age + ", Password: " + password + ", Email: " + email;
        }

        public string Alias
        {
            get
            {
                return alias;
            }

            set
            {
                alias = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}