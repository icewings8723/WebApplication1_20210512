using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Test3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //判定是否已經於其他分頁登入
            if (Session["logined"] != null && Session["logined"] == "1" )   //"1"有登錄過一次
            {
                Response.Redirect("game");
            }


            if (!IsPostBack)
            {
                user.Text = "";
                passwd.Text = "";
                Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                LabelCount.Text = Convert.ToString(Application["count"]);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (user.Text == "lccnet")
            {
                user.Text = "";
                if (passwd.Text == "123456")
                {
                    Response.Redirect("game");
                }
                else
                {
                    passwdLabel.Text = "密碼輸入錯誤";
                }
            }
            else
            {
                userLabel.Text = "帳號輸入錯誤";
            }
        }
    }
}