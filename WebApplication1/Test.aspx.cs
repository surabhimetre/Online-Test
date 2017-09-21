using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Test : System.Web.UI.Page
    {
        static int count;
        int srn;
        public void Page_Load(object sender, EventArgs e)
        {

            count = 0;
            String rn = Request.QueryString["Para"];
            srn = Convert.ToInt32(rn);
            //  Timer1.Enabled = true;
            //  Timer1.Interval = 2000;
            //  Timer1.Tick += new EventHandler<EventArgs>(Timer1_Tick1);
        }

        /*   protected void Timer1_Tick1(object sender, EventArgs e)
           {
           &nbsp;&nbsp;&nbsp;<strong><span class="auto-style6"><asp:Label ID="Label2" runat="server" Text="1"></asp:Label>
               </span></strong>&nbsp;&nbsp;&nbsp;<strong><span class="auto-style6"><asp:Label ID="Label1" runat="server" Text="00"></asp:Label>
               <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick1">
               </asp:Timer>
                   <asp:ScriptManager ID="ScriptManager" runat="server" ></asp:ScriptManager>  
               int s = (Convert.ToInt32(Label1.Text));
               int m = (Convert.ToInt32(Label2.Text));
               int o = 60;

               if (m == 0 && s == 0)
               {
                   Timer1.Enabled = false;
                   Response.Redirect("Login.aspx");
               }
               if (s == 00)
               {
                   m = m - 1;
                   Label2.Text = m.ToString();
                   Label1.Text = o.ToString();
                   s = o;
               }
               s = s - 1;
               Label1.Text = s.ToString();

           }*/
        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
        public void countmarks()
        {
            /* String s = "I don't know";
             String s1 = "Dennis Ritchie";
             String s2 = "2 ohm";
             String s3 = "James Gosling";
            if (RadioButtonList1.SelectedItem.Text == "18 mins")
            {
                count = count + 2;
            }
            else
            {
                count = count - 1;
            }*/
            if (RadioButtonList1.SelectedIndex == 0)
            {
                count = count + 2;
            }
            else if (RadioButtonList1.SelectedIndex == 1 || RadioButtonList1.SelectedIndex == 2 || RadioButtonList1.SelectedIndex == 3)
            {
                count = count - 1;
            }
            
            if (RadioButtonList2.SelectedIndex == 3)
            {
                count = count + 2;
            }
            else if (RadioButtonList2.SelectedIndex == 0 || RadioButtonList2.SelectedIndex ==1 || RadioButtonList2.SelectedIndex == 2)
            {
                count = count - 1;
            }
            if (RadioButtonList3.SelectedIndex == 3)
            {
                count = count + 2;
            }
            else if (RadioButtonList3.SelectedIndex == 0 || RadioButtonList3.SelectedIndex == 1 || RadioButtonList3.SelectedIndex == 2)
            {
                count = count - 1;
            }
            if (RadioButtonList4.SelectedIndex == 2)
            {
                count = count + 2;
            }
            else if (RadioButtonList4.SelectedIndex == 0 || RadioButtonList4.SelectedIndex == 1 || RadioButtonList4.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList5.SelectedIndex == 0)
            {
                count = count + 2;
            }
            else if (RadioButtonList5.SelectedIndex == 1 || RadioButtonList5.SelectedIndex == 2 || RadioButtonList5.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList6.SelectedIndex == 0)
            {
                count = count + 2;
            }
            else if (RadioButtonList6.SelectedIndex == 1 || RadioButtonList6.SelectedIndex == 2 || RadioButtonList6.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList7.SelectedIndex == 1)
            {
                count = count + 2;
            }
            else if (RadioButtonList7.SelectedIndex == 0 || RadioButtonList7.SelectedIndex == 2 || RadioButtonList7.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList8.SelectedIndex == 2)
            {
                count = count + 2;
            }
            else if (RadioButtonList8.SelectedIndex == 0 || RadioButtonList8.SelectedIndex == 1 || RadioButtonList8.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList9.SelectedIndex == 3)
            {
                count = count + 2;
            }
            else if (RadioButtonList9.SelectedIndex == 0 || RadioButtonList9.SelectedIndex == 1 || RadioButtonList9.SelectedIndex == 2)
            {
                count = count - 1;
            }
            if (RadioButtonList10.SelectedIndex == 2)
            {
                count = count + 2;
            }
            else if (RadioButtonList10.SelectedIndex == 0 || RadioButtonList10.SelectedIndex == 1 || RadioButtonList10.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList11.SelectedIndex == 0)
            {
                count = count + 2;
            }
            else if (RadioButtonList11.SelectedIndex == 1 || RadioButtonList11.SelectedIndex == 2 || RadioButtonList11.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList12.SelectedIndex == 0)
            {
                count = count + 2;
            }
            else if (RadioButtonList12.SelectedIndex == 1 || RadioButtonList12.SelectedIndex == 2 || RadioButtonList12.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList13.SelectedIndex == 1)
            {
                count = count + 2;
            }
            else if (RadioButtonList13.SelectedIndex == 0 || RadioButtonList13.SelectedIndex == 2 || RadioButtonList13.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList14.SelectedIndex == 0)
            {
                count = count + 2;
            }
            else if (RadioButtonList14.SelectedIndex == 1 || RadioButtonList14.SelectedIndex == 2 || RadioButtonList14.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList15.SelectedIndex == 1)
            {
                count = count + 2;
            }
            else if (RadioButtonList15.SelectedIndex == 0 || RadioButtonList15.SelectedIndex == 2 || RadioButtonList15.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList16.SelectedIndex == 0)
            {
                count = count + 2;
            }
            else if (RadioButtonList16.SelectedIndex == 1 || RadioButtonList16.SelectedIndex == 2 || RadioButtonList16.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList17.SelectedIndex == 1)
            {
                count = count + 2;
            }
            else if (RadioButtonList17.SelectedIndex == 0 || RadioButtonList17.SelectedIndex == 2 || RadioButtonList17.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList18.SelectedIndex == 2)
            {
                count = count + 2;
            }
            else if (RadioButtonList18.SelectedIndex == 0 || RadioButtonList18.SelectedIndex == 1 || RadioButtonList18.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList19.SelectedIndex == 3)
            {
                count = count + 2;
            }
            else if (RadioButtonList19.SelectedIndex == 0 || RadioButtonList19.SelectedIndex == 1 || RadioButtonList19.SelectedIndex == 2)
            {
                count = count - 1;
            }
            if (RadioButtonList20.SelectedIndex == 0)
            {
                count = count + 2;
            }
            else if (RadioButtonList20.SelectedIndex == 1 || RadioButtonList20.SelectedIndex == 2 || RadioButtonList20.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList21.SelectedIndex == 2)
            {
                count = count + 2;
            }
            else if (RadioButtonList21.SelectedIndex == 0 || RadioButtonList21.SelectedIndex == 1 || RadioButtonList21.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList22.SelectedIndex == 1)
            {
                count = count + 2;
            }
            else if (RadioButtonList22.SelectedIndex == 0 || RadioButtonList22.SelectedIndex == 2 || RadioButtonList22.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList23.SelectedIndex == 2)
            {
                count = count + 2;
            }
            else if (RadioButtonList23.SelectedIndex == 0 || RadioButtonList23.SelectedIndex == 1 || RadioButtonList23.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList24.SelectedIndex == 1)
            {
                count = count + 2;
            }
            else if (RadioButtonList24.SelectedIndex == 0 || RadioButtonList24.SelectedIndex == 2 || RadioButtonList24.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList25.SelectedIndex == 1)
            {
                count = count + 2;
            }
            else if (RadioButtonList25.SelectedIndex == 0 || RadioButtonList25.SelectedIndex == 2 || RadioButtonList25.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList26.SelectedIndex == 1)
            {
                count = count + 2;
            }
            else if (RadioButtonList26.SelectedIndex == 0 || RadioButtonList26.SelectedIndex == 2 || RadioButtonList26.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList27.SelectedIndex == 2)
            {
                count = count + 2;
            }
            else if (RadioButtonList27.SelectedIndex == 0 || RadioButtonList27.SelectedIndex == 1 || RadioButtonList27.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList28.SelectedIndex == 2)
            {
                count = count + 2;
            }
            else if (RadioButtonList28.SelectedIndex == 0 || RadioButtonList28.SelectedIndex == 1 || RadioButtonList28.SelectedIndex == 3)
            {
                count = count - 1;
            }
            if (RadioButtonList29.SelectedIndex == 3)
            {
                count = count + 2;
            }
            else if (RadioButtonList29.SelectedIndex == 0 || RadioButtonList29.SelectedIndex == 1 || RadioButtonList29.SelectedIndex == 2)
            {
                count = count - 1;
            }
            if (RadioButtonList30.SelectedIndex == 0)
            {
                count = count + 2;
            }
            else if (RadioButtonList30.SelectedIndex == 1 || RadioButtonList30.SelectedIndex == 2 || RadioButtonList30.SelectedIndex == 3)
            {
                count = count - 1;
            }
            /* if(RadioButtonList1.SelectedItem.Text.Equals(s1))
             {
                 count = count + 4;
             }
             else if (RadioButtonList1.SelectedItem.Text.Equals(s))
             {

             }
             else
             {
                 count = count - 1;
             }
             if (RadioButtonList2.SelectedItem.Text.Equals(s2))
             {
                 count = count + 4;
             }
             else if (RadioButtonList2.SelectedItem.Text.Equals(s))
             {

             }
             else
             {
                 count = count - 1;
             }
             if (RadioButtonList3.SelectedItem.Text.Equals(s3))
             {
                 count = count + 4;
             }
             else if (RadioButtonList3.SelectedItem.Text.Equals(s))
             {

             }
             else
             {
                 count = count - 1;
             }*/
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {

            countmarks();
            string connstr = @"server=127.0.0.1;Database=college; User Id=root;Password='surabhi97';allow user variables=true";
            try
            {
                MySqlConnection con;
                con = new MySqlConnection(connstr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String str = "UPDATE ROBOCON2 SET MARKS=" + count + " WHERE ROLLNO=" + srn;
                cmd = new MySqlCommand(str, con);
                cmd.ExecuteReader();
                con.Close();
                MsgBox("TEST COMPLETED", this.Page, this);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MsgBox(ex.Message, this.Page, this);
            }

            Response.Redirect("Login.aspx", true);
    }

    }
}