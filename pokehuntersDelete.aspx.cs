using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;

namespace csharp3rdHandin
{
    public partial class pokehuntersDelete : System.Web.UI.Page
    {
        ArrayList PokehunterList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect("pokehunters.aspx");
            }

            HttpCookie cookie = HttpContext.Current.Request.Cookies["organizer"];
            if(cookie != null)
            {
                Response.Redirect("Index.aspx");
            }


            loadTextBox();          
        }

        public void loadTextBox()
        {
            ListBoxPokehunters.Items.Clear();
            try
            {
                PokehunterList = FileUtility.ReadFile(Server.MapPath("~/App_Data/pokehunters.ser"));
                Application["AllPokehunters"] = PokehunterList;
                if (PokehunterList.Count == 0)
                {
                    LabelMessage.Text = "No Pokehunters in file";
                }
                else
                {
                    for (int i = 0; i < PokehunterList.Count; i++)
                    {
                        
                        ListBoxPokehunters.Items.Add(PokehunterList[i].ToString()  + "\n");
                    }
                }
            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;

            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            string getSessionUser = HttpContext.Current.User.Identity.Name;
            foreach (Pokehunter item in PokehunterList.ToArray())
            {
                if(item.Alias == getSessionUser)
                {
                    if (item.Alias == TextBoxAlias.Text)
                    {
                        PokehunterList.Remove(item);
                        Application["AllPokehunters"] = PokehunterList;
                        FileUtility.WriteFile(PokehunterList, Server.MapPath("~/App_Data/pokehunters.ser"));
                        //loadTextBox();
                        Response.Redirect("pokehuntersDelete.aspx");
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    LabelMessage.Text = "You can only delete your own user";
                }
                          
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("pokehunters.aspx");
        }
    }
}