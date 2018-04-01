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
    private String selected_car_id;

    private String n_make;
    private String n_model;
    private String n_price;
    private String n_mpg;
    protected string oldLast;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack)
        {
            if(Session["before"] != null)
            {
                oldLast = ((Car)Session["before"]).Last;
            }
        }
        else
        {
            TextBox_make.Text
        }

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
        Response.Redirect("Default.aspx");
        return;
    }

        

    
}