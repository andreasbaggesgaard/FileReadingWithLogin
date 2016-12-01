using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;

namespace csharp3rdHandin
{
    public partial class organizersDelete : System.Web.UI.Page
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

            LoadListBox();
        }

        public void LoadListBox()
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

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            
                try
                {                
                    foreach (Person item in Organizerlist.ToArray())
                    {
                        
                        if (item.Alias == TextBoxAlias.Text)
                        {
                            Organizerlist.Remove(item);
                            Application["AllOrganizers"] = Organizerlist;
                            FileUtility.WriteFile(Organizerlist, Server.MapPath("~/App_Data/organizers.ser"));
                            LoadListBox();
                        }
                        else
                        {
                            continue;
                        }
                    
                    }

                foreach (Person hunter in PokehunterList.ToArray())
                {
                    if (hunter.Alias == TextBoxAlias.Text)
                    {
                        PokehunterList.Remove(hunter);
                        Application["AllPokehunters"] = PokehunterList;
                        FileUtility.WriteFile(PokehunterList, Server.MapPath("~/App_Data/pokehunters.ser"));
                        LoadListBox();
                    }
                    else
                    {
                        continue;
                    }
                }

            }
                catch (Exception ex)
                {                   
                    LabelMessage.Text = ex.Message;
                }
            }
               
        }
    }

