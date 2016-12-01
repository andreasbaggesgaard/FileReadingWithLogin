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
    public partial class pokehunters : System.Web.UI.Page
    {
        ArrayList PokehunterList;

        protected void Page_Load(object sender, EventArgs e)
        {
            //PokehunterList = FileUtility.ReadFile(Server.MapPath("~/App_Data/pokehunters.ser"));
            //Application["AllPokehunters"] = PokehunterList;

            if (!this.Page.User.Identity.IsAuthenticated)
            {
                
                ButtonDelete.Enabled = false;
                ButtonUpdate.Enabled = false;
                //ButtonRead.Enabled = false;
                ButtonLogout.Enabled = false;
            }

            try
            {       
                if (Application["AllPokehunters"] == null)
                {
                    PokehunterList = new ArrayList();
                    Application["AllPokehunters"] = PokehunterList;                    
                }

                PokehunterList = (ArrayList)Application["AllPokehunters"];

                if (PokehunterList.Count == 0)
                {
                    LabelMessage.Text = "No Pokehunters";
                }
                else
                {
                    ListBoxPokehunters.Items.Clear();
                    for (int i = 0; i < PokehunterList.Count; i++)
                    {
                        ListBoxPokehunters.Items.Add(PokehunterList[i].ToString());
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
                PokehunterList = (ArrayList)Application["AllPokehunters"];
                FileUtility.WriteFile(PokehunterList, Server.MapPath("~/App_Data/pokehunters.ser"));
                LabelMessage.Text = "Information has been saved in file";         
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("pokehuntersCreate.aspx");
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("pokehuntersUpdate.aspx");
        }

        protected void ButtonRead_Click(object sender, EventArgs e)
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
                    LabelMessage.Text = "Pokehunters from file\n";
                    for (int i = 0; i < PokehunterList.Count; i++)
                    {
                        ListBoxPokehunters.Items.Add(PokehunterList[i].ToString() + "\n");
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
            Response.Redirect("pokehuntersDelete.aspx");
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
          
            PokehunterList = FileUtility.ReadFile(Server.MapPath("~/App_Data/pokehunters.ser"));
            Application["AllPokehunters"] = PokehunterList;

            try
            {
                string username = TextBoxName.Text;
                string password = TextBoxPassword.Text;

                foreach (Pokehunter p in PokehunterList)
                {
                    if (p.Alias == username && p.Password == password)
                    {
                        FormsAuthentication.SetAuthCookie(TextBoxName.Text.ToLower(), true);

                        HttpCookie cookie = new HttpCookie("pokehunter");
                        HttpContext.Current.Response.Cookies.Add(cookie);

                        LabelLogin.Text = "You are now logged in";
                        ButtonDelete.Enabled = true;
                        ButtonUpdate.Enabled = true;
                        ButtonRead.Enabled = true;
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

            HttpCookie cookie = HttpContext.Current.Request.Cookies["pokehunter"];
            cookie.Expires = DateTime.Now.AddDays(-1);
            HttpContext.Current.Response.Cookies.Add(cookie);

            Response.Redirect("pokehunters.aspx");
        }
    }
}