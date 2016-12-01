using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;

namespace csharp3rdHandin
{
    public partial class pokehuntersUpdate : System.Web.UI.Page
    {
        ArrayList PokehunterList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect("pokehunters.aspx");
            }

            HttpCookie cookie = HttpContext.Current.Request.Cookies["organizer"];
            if (cookie != null)
            {
                Response.Redirect("Index.aspx");
            }

            loadTextBox();
        }

        public void loadTextBox()
        {
            ListBoxHunters.Items.Clear();

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
                        ListBoxHunters.Items.Add(PokehunterList[i].ToString() + "\n");
                    }
                }
            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;

            }
        }

        protected void ButtonChangeEmail_Click(object sender, EventArgs e)
        {
            string oldEmail = TextBoxOldEmail.Text;
            string newEmail = TextBoxNewEmail.Text;
            string getSessionUser = HttpContext.Current.User.Identity.Name;


            foreach (Pokehunter p in PokehunterList)
            {
                if (p.Alias == getSessionUser)
                {
                    if (p.Email == oldEmail)
                    {
                        p.ChangeEmail(newEmail);
                        LabelMessage.Text = oldEmail + " was changed to " + newEmail;
                        PokehunterList = (ArrayList)Application["AllPokehunters"];
                        FileUtility.WriteFile(PokehunterList, Server.MapPath("~/App_Data/pokehunters.ser"));
                        loadTextBox();

                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    LabelMessage.Text = "You can only update your own user";
                }
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("pokehunters.aspx");
        }
    }
}