using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if(username.Text == ConfigurationManager.AppSettings["user"] 
                && psw.Text == ConfigurationManager.AppSettings["psw"])
            {
                message.Text = "Login effettuato con successo";
                HttpCookie auth = new HttpCookie("authCookie");
                auth.Values["user"] = username.Text;
                auth.Values["psw"] = psw.Text;
                Response.Cookies.Add(auth);
            }
            else
            {
                message.Text = "Username o Password sbagliate!";
            }
        }
    }
}