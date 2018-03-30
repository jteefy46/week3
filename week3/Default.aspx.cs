using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.Entity;
using MySql.Data;
using MySql.Web;
using MySql.Data.MySqlClient;


public partial class _Default : System.Web.UI.Page
{
    MySqlConnection con;
    private bool m_ConnectionOpen;
    protected void Page_Load(object sender, EventArgs e)
    {
        m_ConnectionOpen = false;
        String cnx = "Database=Car;Data Source=localhost;User Id=root;SslMode=none";
        con = new MySqlConnection(cnx);
        try
        {
            con.Open();
            m_ConnectionOpen = true;
        }catch(Exception ex)
        {
            Response.Write("The connection could not be opened - " + ex.ToString());
        }
        if(con.State == System.Data.ConnectionState.Open)
        
        {
            Session["MySqlConnection"] = con;
            Response.Write("Connection Established <br/>");
            String query = "SELECT * FROM CarInfo";
            MySqlCommand cmd = new MySqlCommand(query, con );
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                String make = rdr["car_make"].ToString();
                String model = rdr["car_model"].ToString();
                String price = rdr["price"].ToString();
                String mpg = rdr["mpg"].ToString();

                
                String entry = "<tr>" + "<td>" + make ;
                entry += model  + "</td>" + "</tr>";
                entry += "$"+ price  + "</td>" + "</tr>";
                entry += mpg + "<br/>" + "</td>" + "</tr>";
                Response.Write(entry);
            }
            rdr.Close();//do not forget
            Response.Write("</table>");
            Session["MySqlConnection"] = con;
            Session["Last_Query"] = "None";

        }
        else
        {
            Response.Write("Connection Failed! <br/>");
            Response.Write(con.State.ToString() + "<br/>");
        }
    }

    protected void GoToEnterCarInfo(object sender, EventArgs e)
    {
        Response.Redirect("carinfo.aspx");
    }

    
}