using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class game : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logined"] == null)
            {
                //Response.Redirect("Test3");
            }
            Application["count"] = Convert.ToInt32(Application["count"]) + 1;
            Label1.Text = "目前線上人數:" + Application["count"];
        }

        static int ct = 30;

        protected void Button_Click(object sender, ImageClickEventArgs e)
        {
            
            int user = 0;
            if (sender == ImageButton1)
            {
                user = 1;
                userResult.Text = "玩家出剪刀";
            }
            else if (sender == ImageButton2)
            {
                user = 2;
                userResult.Text = "玩家出石頭";
            }
            else if (sender == ImageButton3)
            {
                user = 3;
                userResult.Text = "玩家出布";
            }

            Random rnd = new Random();
            int computer = rnd.Next(1, 4);
            if (computer == 1)
            {
                computerResult.Text = "電腦出剪刀";
                computerImage.ImageUrl = "~/pic/scissors.png";
            }
            else if (computer == 2)
            {
                computerResult.Text = "電腦出石頭";
                computerImage.ImageUrl = "~/pic/stone.png";
            }
            else if (computer == 3)
            {
                computerResult.Text = "電腦出布";
                computerImage.ImageUrl = "~/pic/paper.png";
            }


            if ((user == 1 && computer == 3) ||
                (user == 2 && computer == 1) ||
                (user == 3 && computer == 2))
            {
                final.Text = "玩家贏了";
                Session["win"] = Convert.ToInt32(Session["win"]) + 1;
                LabelWin.Text = "共贏了" + Session["win"] + "次";
            }

            else if ((user == 1 && computer == 2)
                || (user == 2 && computer == 3)
                || (user == 3 && computer == 1))
            {
                final.Text = "玩家輸了";
                Session["lose"] = Convert.ToInt32(Session["lose"]) + 1;
                LabelLose.Text = "共輸了" + Session["lose"] + "次";
            }
            else
            {
                final.Text = "平手";
                Session["tie"] = Convert.ToInt32(Session["tie"]) + 1;
                LabelTie.Text = "共平手" + Session["tie"] + "次";

            }
            
        }

        protected void ButtonExit_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            ct--;
            Label2.Text = "倒數時間:" + ct.ToString();
            

        }
    }
}