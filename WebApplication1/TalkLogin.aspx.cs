using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class TalkLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logined"] != null && Session["logined"].ToString() == "1")
            {
                Response.Redirect("test2");
            }
            else
            {
                /*
                if (Request.Form["user"] != null && Request.Form["passwd"] != null)
                {
                    if (Request.Form["user"] == "lccnet" && Request.Form["passwd"] == "123456")
                    {
                        Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                        Session["name"] = Request.Form["name"];
                        Session["logined"] = "1";
                        Response.Redirect("test2");
                    }
                }
                else
                {
                    Response.Write("error");
                }
                */
                //創一個變數存放從config內的資訊，其實也可不用創立這變數，直接放進SqlConnection內即可。
                string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AccountConnectionString2"].ConnectionString;

                //new一個SqlConnection物件，是與資料庫連結的通道(其名為Connection)，以s_data內的連接字串連接所對應的資料庫。
                SqlConnection connection = new SqlConnection(s_data);
                string AccountSQL = "select * from Account where username ='" + Request.Form["user"]+"'";
                //new一個SqlCommand告訴這個物件準備要執行什麼SQL指令
                SqlCommand Command = new SqlCommand(AccountSQL, connection);

                //與資料庫連接的通道開啟
                connection.Open();

                //new一個DataReader接取Execute所回傳的資料。
                SqlDataReader Reader = Command.ExecuteReader();

                //檢查是否有資料列
                if (Reader.HasRows)
                {
                    //使用Read方法把資料讀進Reader，讓Reader一筆一筆順向指向資料列，並回傳是否成功。
                    if (Reader.Read())
                    {
                        if (Reader["passwd"].ToString() == Request.Form["passwd"])
                        {
                            Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                            Session["name"] = Request.Form["name"];
                            Session["logined"] = "1";
                            Response.Redirect("Talk");
                        }
                        else
                        {
                            Label1.Text = "密碼錯誤";
                        }

                    }
                    else
                    {
                        Label1.Text = "無此帳號";
                    }
                }

                //關閉與資料庫連接的通道
                connection.Close();
            }
        }
    }
}