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

public partial class carinfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Add_Car(object sender, EventArgs e)
    {
        MySqlConnection con = (MySqlConnection)Session["MySqlConnection"];
        if(con.State != System.Data.ConnectionState.Open)
        {
            Session["Last_Error"] = "Error Connection Lost";
            Response.Redirect("Error.aspx");
            return;
        }

        String make = TextBox_make.Text;
        String model = TextBox_model.Text;
        String price = TextBox_make.Text;
        String mpg = TextBox_mpg.Text;

        String query = @"Insert into CarInfo(car_make, car_model, price, mpg )values('" + make +"', '" + model + "', '" + price + "', '" + mpg + "')";
        MySqlCommand cmd = new MySqlCommand(query, con);
        try
        {
            cmd.ExecuteNonQuery();

        }catch(Exception exep)
        {
            String error = exep.Message;
            Session["Last_Error"] = error;
            Response.Redirect("Error.aspx");
            return;
        }
        Response.Redirect("Default.aspx");
        return;

    }
}