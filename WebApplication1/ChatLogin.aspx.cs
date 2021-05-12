using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ChatLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["name"] != null)
            {
                Session["name"] = Request.Form["name"];
                //Response.Redirect("Handler1.ashx");
                Server.Transfer("Handler.ashx");   //Handler 的public要加上 System.Web.UI.Page
                //var handlerTest = new Handler1();
                //handlerTest.ProcessRequest(Context);
                //Response.End();
            }

            /*
            //判定是否已經於其他分頁登入
            if (Session["logined"] != null && Session["logined"] == "1")   //"1"有登錄過一次
            {
                Response.Redirect("chat");
            }
            else 
            {
                if (Request.Form["user"] != null && Request.Form["passwd"] != null)
                {
                    if (Request.Form["user"] == "lccnet" && Request.Form["passwd"] == "123456")
                    {
                        Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                        Session["name"] = Request.Form["name"];
                        Response.Redirect("chat");
                    }
                }
                else
                {
                    Response.Write("error");
                }   
            */





            if (!IsPostBack)
            {
                user.Text = "使用者名稱";
                passwd.Text = "使用者密碼";
                name.Text = "姓名";
                Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                LabelCount.Text = Convert.ToString(Application["count"]);
            }
            user.Attributes.Add("onFocus", "this.value=''");//一點擊TextBox1後，裡面的字馬上被清空
            passwd.Attributes.Add("onFocus", "this.value=''");//一點擊TextBox1後，裡面的字馬上被清空
            name.Attributes.Add("onFocus", "this.value=''");//一點擊TextBox1後，裡面的字馬上被清空
            
         }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            /*
            if (user.Text == "lccnet")
            {
                user.Text = "";
                if (passwd.Text == "123456")
                {
                    Response.Redirect("chat");
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
            */
        }

        protected void user_TextChanged(object sender, EventArgs e)
        {
  
        }
        
    }
}