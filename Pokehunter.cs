using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csharp3rdHandin
{
    [Serializable]
    public class Pokehunter : Person
    {
        protected string favouritePokemon;

        public Pokehunter(string alias, string name, int age, string password, string email, string FavouritePokemon) : base(alias, name, age, password, email)
        {
            this.FavouritePokemon = FavouritePokemon;
        }

        public string FavouritePokemon
        {
            get
            {
                return favouritePokemon;
            }

            set
            {
                favouritePokemon = value;
            }
        }

        public override string ToString()
        {
            return " Pokehunter: Alias: " + alias + ", Name: " + name + ", Age: " + age + ", Password: " + password + ", Email: " + email + ", Favourite Pokemon: " + favouritePokemon;
        }
    }
}