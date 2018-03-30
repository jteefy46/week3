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

public partial class EditCar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Validate_changes(object sender, EventArgs e)
    {
        MySqlConnection con = (MySqlConnection)Session["MySqlConnection"];
        String make = TextBox_make.Text;
        String model = TextBox_make.Text;
        String price = TextBox_price.Text;
        String mpg = TextBox_mpg.Text;

        String sql_command = "update CarInfo set car_make = '" + make + "', car_model  '" + model + "', price '" + price + "', mpg'" + mpg;
        Response.Write(sql_command + "<br/>");
        MySqlCommand cmd = new MySqlCommand(sql_command, con);
        cmd.ExecuteNonQuery();
    }


    protected void Edit_Car_Event_Handler(object sender, EventArgs e)
    {

    }
}