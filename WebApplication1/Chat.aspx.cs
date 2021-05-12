using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class chat : System.Web.UI.Page
    {
        static int ct = 30;
        protected void Page_Load(object sender, EventArgs e)
        {
              //name.Text = Session["name"].ToString();
            
        }

        protected void sendRtn_Click(object sender, EventArgs e)
        {
            string message = inputText.Text;
            //Application["messageResult"] = Application["messageResult"] + Session["name"].ToString() + ":" + message + "<br>";
            
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if(Application["MessageResult"] != null)
            chatResult.Text = Application["MessageResult"].ToString();
        }
    }
}