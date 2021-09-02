using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btn1.Text = "Kliknij mnie";
            }
            else
            {
                btn1.Text = tbName.Text;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}