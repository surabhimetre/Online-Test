using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        int srn;
        String sname;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim() == string.Empty || TextBox2.Text.Trim() == string.Empty)
            {
                MsgBox("Kindly fill all the details",this.Page,this);
                return; // return because we don't want to run normal code of buton click
            }
            else
            {

                srn = Convert.ToInt32(TextBox2.Text);
                sname = Convert.ToString(TextBox1.Text);
            }
            string connstr = @"server=127.0.0.1;Database=college; User Id=root;Password='surabhi97';allow user variables=true";
            try
            {
                MySqlConnection con;
                con = new MySqlConnection(connstr);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                String str = "INSERT INTO ROBOCON2(Rollno,Name) VALUES(" + srn + ",'" + sname + "')";
                cmd = new MySqlCommand(str, con);
                cmd.ExecuteReader();
                con.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MsgBox(ex.Message, this.Page, this);
            }
            Response.Redirect("Test.aspx?Para=" + srn, true);
        }
    }
}