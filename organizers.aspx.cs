using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;
using System.Web.Security;

namespace csharp3rdHandin
{
    public partial class organizers : System.Web.UI.Page
    {
        ArrayList Organizerlist;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {

                ButtonDelete.Enabled = false;
                ButtonUpdate.Enabled = false;
                //ButtonRead.Enabled = false;
                ButtonLogout.Enabled = false;
            }

            try
            {
                if (Application["AllOrganizers"] == null)
                {
                    Organizerlist = new ArrayList();
                    Application["AllOrganizers"] = Organizerlist;
                }

                Organizerlist = (ArrayList)Application["AllOrganizers"];

                if (Organizerlist.Count == 0)
                {
                    LabelMessage.Text = "No Organizers";
                }
                else
                {
                    ListBoxOrganizers.Items.Clear();
                    for (int i = 0; i < Organizerlist.Count; i++)
                    {
                        ListBoxOrganizers.Items.Add(Organizerlist[i].ToString() + "\n");
                    }

                }
            }
            catch (Exception ex)
            {

                LabelMessage.Text = ex.Message;
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Organizerlist = (ArrayList)Application["AllOrganizers"];
            FileUtility.WriteFile(Organizerlist, Server.MapPath("~/App_Data/organizers.ser"));
            LabelMessage.Text = "Information has been saved in file";
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("orgranizersCreate.aspx");
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("organizersUpdate.aspx");
        }

        protected void ButtonRead_Click(object sender, EventArgs e)
        {
            ListBoxOrganizers.Items.Clear();
            try
            {
                Organizerlist = FileUtility.ReadFile(Server.MapPath("~/App_Data/organizers.ser"));
                Application["AllOrganizers"] = Organizerlist;
                if (Organizerlist.Count == 0)
                {
                    ListBoxOrganizers.Text = "No organizers in file";
                }
                else
                {
                    ListBoxOrganizers.Text = "Organizers from file\n";
                    for (int i = 0; i < Organizerlist.Count; i++)
                    {
                        ListBoxOrganizers.Items.Add(Organizerlist[i].ToString() + "\n");
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
            Response.Redirect("Index.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("organizersDelete.aspx");
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
           
            Organizerlist = FileUtility.ReadFile(Server.MapPath("~/App_Data/organizers.ser"));
            Application["AllOrganizers"] = Organizerlist;

            try
            {
                string username = TextBoxName.Text;
                string password = TextBoxPassword.Text;

                foreach (Organizers o in Organizerlist)
                {
                    if (o.Alias == username && o.Password == password)
                    {
                       
                        FormsAuthentication.SetAuthCookie(TextBoxName.Text.ToLower(), true);

                        HttpCookie cookie = new HttpCookie("organizer");
                        cookie.Expires = DateTime.Now.AddDays(1);
                        HttpContext.Current.Response.Cookies.Add(cookie);
                        

                        LabelLogin.Text = "You are now logged in";
                        ButtonDelete.Enabled = true;
                        ButtonUpdate.Enabled = true;
                        //ButtonRead.Enabled = true;
                        ButtonLogout.Enabled = true;

                    }
                    else
                    {
                        continue;
                    }

                }
            }
            catch (Exception ex)
            {
                //LabelMessage.Text = ex.Message;
                LabelMessage.Text = "No match";

            }
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();

            HttpCookie cookie = HttpContext.Current.Request.Cookies["organizer"];
            cookie.Expires = DateTime.Now.AddDays(-1);
            HttpContext.Current.Response.Cookies.Add(cookie);

            Response.Redirect("organizers.aspx");
        }
    }
}