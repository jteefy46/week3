using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cars
/// </summary>
public class Cars
{
    public int m_id;
    public string m_make;
    public string m_model;
    public double m_price;
    public int m_mpg;

    public Cars(int id, String make, String model, double price, int mpg)
    {
        m_id = id;
        m_make = make;
        m_model = model;
        m_price = price;
        m_mpg = mpg;
    }
}