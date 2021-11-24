using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie cokie = new HttpCookie("cookie_test");
            //cokie.Value = "Carlitos Gonzales";
            //Response.Cookies.Add(cokie);

            //var cookie_value = Response.Cookies["cookie_test"].Value;
            //Label1.Text = cookie_value;

            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            // --------------- Adding Coockies ---------------------//
            if (auriculares.Checked)
                Response.Cookies["computer"]["auriculares"] = "Audifonos";
            if (teclados.Checked)
                Response.Cookies["computer"]["teclados"] = "Teclado TKL";

            // --------------- Fetching Cookies -----------------------//
            if (Request.Cookies["computer"].Values.ToString() != null)
            {
                if (Request.Cookies["computer"][""] != null)
                    Label3.Text += Request.Cookies["computer"]["auriculares"] + " ";
                if (Request.Cookies["computer"]["teclados"] != null)
                    Label3.Text += Request.Cookies["computer"]["teclados"];
            }
            else Label3.Text = "Selecciona uno de la lista";
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
        }
    }
}