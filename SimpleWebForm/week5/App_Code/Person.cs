using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


public class Person
{
    private string fname;
    private string mname;
    private string lname;
    private string streetone;
    private string streettwo;
    private string city;
    private string state;
    private string zipcode;
    private string phone;
    private string email;
    private string feedback;

    public string Feedback
    {
        get { return feedback;  }
        set { feedback = value; }
    }
    public string FName
    {
        get
        {
            return fname;
        }
        set
        {
            if (Validation.GotBadWords(value))
            {
                Feedback += "<br />" + "*ERROR. Enter correct first name.";
            }
            else
            {
                fname = value; 
            }
            if (Validation.IsItFilledIn(value))
            {
                fname = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in.";
            }
        }
    }

    public string MName
    {
        get
        {
            return mname;
        }
        set
        {
            if (Validation.GotBadWords(value))
            {
                Feedback += "<br />" + "*ERROR. Enter correct middle name";
            }
            else
            {
                mname = value;
            }
            if (Validation.IsItFilledIn(value))
            {
                mname = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in.";
            }
        }
    }

    public string LName
    {
        get
        {
            return lname;
        }
        set
        {
            if (Validation.GotBadWords(value))
            {
                Feedback += "<br />" + "*ERROR. Enter correct last name";
            }
            else
            {
                lname = value;
            }
            if (Validation.IsItFilledIn(value))
            {
                lname = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in.";
            }
        }
    }

    public string StreetOne
    {
        get
        {
            return streetone;
        }

        set
        {
            if(Validation.IsItFilledIn(value))
            {
                streetone = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in.";
            }
            
        }
    }

    public string StreetTwo
    {
        get
        {
            return streettwo;
        }
        set
        {
            if (Validation.IsItFilledIn(value))
            {
                streettwo = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in.";
            }

        }
    }

    public string City
    {
        get
        {
            return city;
        }
        set
        {
            if (Validation.IsItFilledIn(value))
            {
                city = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in.";
            }

        }
    }

    public string State
    {
        get
        {
            return state;
        }
        set
        {
            if (Validation.IsItFilledIn(value))
            {
                state = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in.";
            }

        }
    }

    public string ZipCode
    {
        get
        {
            return zipcode;
        }
        set
        {
            if (Validation.IsItFilledIn(value))
            {
                zipcode = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in.";
            }

        }
    }

    public string Phone
    {
        get
        {
            return phone;
        }
        set
        {
            if (Validation.IsItFilledIn(value))
            {
                phone = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in.";
            }

        }
    }

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            if (Validation.IsItFilledIn(value))
            {
                email = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in";
            }

            if (Validation.IsValidEmail(value))
            {
                email = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Enter a valid email address.";
            }
        }
    }



    public Person()
    {
        fname = "";
        mname = "";
        lname = "";
        streetone = "";
        streettwo = "";
        city = "";
        state = "";
        zipcode = "";
        phone = "";
        email = "";

        feedback = "";
    }
}

