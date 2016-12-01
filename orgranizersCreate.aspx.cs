using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;
namespace csharp3rdHandin
{
    public partial class orgranizersCreate : System.Web.UI.Page
    {
        ArrayList Organizerlist;

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
            
            Person p = new Organizers(alias, name, Convert.ToInt32(age), password, email);

            if (p.ChangeEmail(email))
            {
                Organizerlist = (ArrayList)Application["AllOrganizers"];
                Organizerlist.Add(p);
                Response.Redirect("organizers.aspx");
            }
            else
            {
                LabelMessage.Text = "email must end with @poke.dk";
            }

        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("organizers.aspx");
        }
    }
}