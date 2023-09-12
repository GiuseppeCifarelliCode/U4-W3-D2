using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class home : System.Web.UI.Page
    {
        int ridottiNord;
        int ridottiEst;
        int ridottiSud;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["authCookie"] == null)
            {
                message.Text = "Non sei loggato! Non ce n'è COVIDDI, vai a loggarti!";
                Response.Redirect("default.aspx");
            }

            if (!IsPostBack)
            {
                if (Session["salaNord"] == null)
                    Session["salaNord"] = new List<sala>();

                if (Session["salaEst"] == null)
                    Session["salaEst"] = new List<sala>();

                if (Session["salaSud"] == null)
                    Session["salaSud"] = new List<sala>();
                ridottiNord = 0;
                ridottiEst = 0;
                ridottiSud = 0;
            }
        }

        protected void buyTicket(object sender, EventArgs e)
        {
            string option = sale.SelectedValue;
            switch (option)
            {
                case "nord":
                    sala utente1 = new sala(nome.Text, cognome.Text, ridotto.Checked);
                    ((List<sala>)Session["salaNord"]).Add(utente1);
                    foreach (sala utente in (List<sala>)Session["salaNord"]) { if (utente.ridotto) ridottiNord += 1; }
                    nordLabel.Text = $"Sala Nord --- Biglietti Venduti: {((List<sala>)Session["salaNord"]).Count} --- Ridotti: {ridottiNord}";
                    nome.Text = "";
                    cognome.Text = "";
                    ridotto.Checked = false;
                    break;

                case "est":
                    sala utente2 = new sala(nome.Text, cognome.Text, ridotto.Checked);
                    ((List<sala>)Session["salaEst"]).Add(utente2);
                    foreach (sala utente in (List<sala>)Session["salaEst"]) { if (utente.ridotto) ridottiEst += 1; }
                    estLabel.Text = $"Sala Est --- Biglietti Venduti: {((List<sala>)Session["salaEst"]).Count} --- Ridotti: {ridottiEst}";
                    nome.Text = "";
                    cognome.Text = "";
                    ridotto.Checked = false;
                    break;

                case "sud":
                    sala utente3 = new sala(nome.Text, cognome.Text, ridotto.Checked);
                    ((List<sala>)Session["salaSud"]).Add(utente3);
                    foreach (sala utente in (List<sala>)Session["salaSud"]) { if (utente.ridotto) ridottiSud += 1; }
                    sudLabel.Text = $"Sala Sud --- Biglietti Venduti: {((List<sala>)Session["salaSud"]).Count} --- Ridotti: {ridottiSud}";
                    nome.Text = "";
                    cognome.Text = "";
                    ridotto.Checked = false;
                    break;
            }
            message.Text = "Ticket Comprato!";

        }
    }
}