using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace csharp3rdHandin
{
    public partial class Index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonPokehunters_Click(object sender, EventArgs e)
        {
            Response.Redirect("pokehunters.aspx");
        }

        protected void ButtonOrganizers_Click(object sender, EventArgs e)
        {
            Response.Redirect("organizers.aspx");
        }


    }
}