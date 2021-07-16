using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
   
    protected void btn1_Click(object sender, EventArgs e)
    {
        // Send the "1" to the LCD
        txtLCD.Text += "1";
    }
    protected void btn2_Click(object sender, EventArgs e)
    {
        // Send the "2" to the LCD
        txtLCD.Text += "2";
    }
    protected void btn3_Click(object sender, EventArgs e)
    {
        // Send the "3" to the LCD
        txtLCD.Text += "3";
    }
    protected void btn4_Click(object sender, EventArgs e)
    {
        // Send the "4" to the LCD
        txtLCD.Text += "4";
    }

    protected void btn5_Click(object sender, EventArgs e)
    {
        // Send the "5" to the LCD
        txtLCD.Text += "5";
    }

    protected void btn6_Click(object sender, EventArgs e)
    {
        // Send the "6" to the LCD
        txtLCD.Text += "6";
    }

    protected void btn7_Click(object sender, EventArgs e)
    {
        // Send the "7" to the LCD
        txtLCD.Text += "7";
    }

    protected void btn8_Click(object sender, EventArgs e)
    {
        // Send the "8" to the LCD
        txtLCD.Text += "8";
    }

    protected void btn9_Click(object sender, EventArgs e)
    {
        // Send the "9" to the LCD
        txtLCD.Text += "9";
    }

    protected void btn0_Click(object sender, EventArgs e)
    {
        // Send the "0" to the LCD
        txtLCD.Text += "0";
    }
    protected void btnDecimal_Click(object sender, EventArgs e)
    {
        // Send the "." to the LCD
        txtLCD.Text += ".";
    }














    protected void btnPlus_Click(object sender, EventArgs e)
    {
        // store the first number (num1)
        lblNum1.Text = txtLCD.Text;

        // store the operand
        Session["operand"] = "+";
        
        // clear the display
        txtLCD.Text = "";


    }
    protected void btnSubtract_Click(object sender, EventArgs e)
    {
        // store the first number (num1)
        lblNum1.Text = txtLCD.Text;

        // store the operand
        Session["operand"] = "-";

        // clear the display
        txtLCD.Text = "";
    }

    protected void btnTimes_Click(object sender, EventArgs e)
    {
        // store the first number (num1)
        lblNum1.Text = txtLCD.Text;

        // store the operand
        Session["operand"] = "*";

        // clear the display
        txtLCD.Text = "";
    }

    protected void btnDivide_Click(object sender, EventArgs e)
    {
        // store the first number (num1)
        lblNum1.Text = txtLCD.Text;

        // store the operand
        Session["operand"] = "/";

        // clear the display
        txtLCD.Text = "";
    }









    protected void btnEqual_Click(object sender, EventArgs e)
    {
        // Store Num2
        double Num2 = double.Parse(txtLCD.Text);
        double Num1 = double.Parse(lblNum1.Text);
        double Result = 0;
        
        // Execute math
        if(Session["operand"].ToString() == "+")
        {
            Result = Num1 + Num2;
        }
        else if (Session["operand"].ToString() == "-")
        {
            Result = Num1 - Num2;
        }
        else if (Session["operand"].ToString() == "*")
        {
            Result = Num1 * Num2;
        }
        else if (Session["operand"].ToString() == "/")
        {
            Result = Num1 / Num2;
        }


        // Replace current display with result
        txtLCD.Text = Result.ToString();


    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Clears the LCD
        txtLCD.Text = "";
        

    }












    protected void memStored_Click(object sender, EventArgs e)
    {
        memLabel.Text = txtLCD.Text;
    }

    protected void memRestored_Click(object sender, EventArgs e)
    {
        txtLCD.Text = memLabel.Text;
    }

    protected void memCleared_Click(object sender, EventArgs e)
    {
        memLabel.Text = "";
    }


}