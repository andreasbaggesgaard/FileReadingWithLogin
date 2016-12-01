using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;

namespace csharp3rdHandin
{
    public partial class organizersUpdate : System.Web.UI.Page
    {
        ArrayList Organizerlist;
        ArrayList PokehunterList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect("organizers.aspx");
            }

            HttpCookie cookie = HttpContext.Current.Request.Cookies["pokehunter"];
            if (cookie != null)
            {
                Response.Redirect("Index.aspx");
            }

            loadListBox();
        }
        public void loadListBox()
        {
            ListBoxOrganizers.Items.Clear();

            try
            {
                Organizerlist = FileUtility.ReadFile(Server.MapPath("~/App_Data/organizers.ser"));
                Application["AllOrganizers"] = Organizerlist;
                if (Organizerlist.Count == 0)
                {
                    LabelMessage.Text = "No Organizers in file";
                }
                else
                {
                    for (int i = 0; i < Organizerlist.Count; i++)
                    {
                        ListBoxOrganizers.Items.Add(Organizerlist[i].ToString() + "\n");
                    }
                }

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
                        ListBoxOrganizers.Items.Add(PokehunterList[i].ToString() + "\n");

                    }
                }
            }
            catch (Exception ex)
            {
                LabelMessage.Text = ex.Message;

            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("organizers.aspx");
        }

        protected void ButtonChangeEmail_Click(object sender, EventArgs e)
        {
            string oldEmail = TextBoxOldEmail.Text;
            string newEmail = TextBoxNewEmail.Text;

            foreach (Person o in Organizerlist)
            {
                if (o.Email == oldEmail)
                {
                    if (o.ChangeEmail(newEmail))
                    {
                        o.ChangeEmail(newEmail);
                        LabelMessage.Text = oldEmail + " was changed to " + newEmail;
                        Organizerlist = (ArrayList)Application["AllOrganizers"];
                        FileUtility.WriteFile(Organizerlist, Server.MapPath("~/App_Data/organizers.ser"));
                        loadListBox();
                    }
                    else
                    {
                        LabelMessage.Text = "Email must end with @poke.dk";
                    }
                }
                else
                {
                    continue;
                }
            }

            foreach(Person p in PokehunterList)
            {
                if (p.Email == oldEmail)
                {
                    p.ChangeEmail(newEmail);
                    LabelMessage.Text = oldEmail + " was changed to " + newEmail;
                    PokehunterList = (ArrayList)Application["AllPokehunters"];
                    FileUtility.WriteFile(PokehunterList, Server.MapPath("~/App_Data/pokehunters.ser"));
                    loadListBox();                      
                }
                else
                {
                    continue;
                }
            }


        }
    }
}