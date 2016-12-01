using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;

namespace csharp3rdHandin
{
    public partial class pokehuntersCreate : System.Web.UI.Page
    {
        ArrayList PokehunterList;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            var alias = TextBoxAlias.Text;
            var name = TextBoxName.Text;
            var age = TextBoxAge.Text;
            var password = TextBoxPassword.Text;
            var email = TextBoxEmail.Text;
            var favPokemon = TextBoxFavPokemon.Text;

            Person p1 = new Pokehunter(alias, name, Convert.ToInt32(age), password, email, favPokemon);
            PokehunterList = (ArrayList)Application["AllPokehunters"];
            PokehunterList.Add(p1);

            Response.Redirect("pokehunters.aspx");
         }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("pokehunters.aspx");
        }
    }
}