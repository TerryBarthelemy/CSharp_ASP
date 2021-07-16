using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;




public class PersonV2 : Person
{
    private string cellphone;
    private string facebook;

    private int peopleID;

    public string Cellphone
    {
        get
        {
            return cellphone;
        }

        set
        {
            if (Validation.IsItFilledIn(value))
            {
                cellphone = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in.";
            }
        }

    }

    public string Facebook
    {
        get
        {
            return facebook;
        }

        set
        {
            if (Validation.IsItFilledIn(value))
            {
                facebook = value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. Field MUST be filled in.";
            }
        }
    }

    public Int32 PeopleID
    {
        get
        {
            return peopleID;
        }

        set
        {
            if (value >= 0)
            {
                peopleID= value;
            }
            else
            {
                Feedback += "<br />" + "*ERROR. You entered an invalid Person ID.";
            }
        }
    }

    private string Connection()
    {
        return "Server=sql.neit.edu\\StudentSqlServer,4500;Database=SE245_TBarthelemy;User Id=SE245_TBarthelemy;Password=008004925;";
    }

    public string AddARecord()
    {

        string strResult = "";


        SqlConnection Conn = new SqlConnection();


        Conn.ConnectionString = @Connection();



        string strSQL = "INSERT INTO Persons (FName, MName, LName, StreetOne, StreetTwo, City, State, ZipCode, Phone, Email, Facebook, Cellphone) VALUES (@FName, @MName, @LName, @StreetOne, @StreetTwo, @City, @State, @ZipCode, @Phone, @Email, @Facebook, @Cellphone)";

        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;
        comm.Connection = Conn;

        comm.Parameters.AddWithValue("@FName", FName);
        comm.Parameters.AddWithValue("@MName", MName);
        comm.Parameters.AddWithValue("@LName", LName);
        comm.Parameters.AddWithValue("@StreetOne", StreetOne);
        comm.Parameters.AddWithValue("@StreetTwo", StreetTwo);
        comm.Parameters.AddWithValue("@City", City);
        comm.Parameters.AddWithValue("@State", State);
        comm.Parameters.AddWithValue("@ZipCode", ZipCode);
        comm.Parameters.AddWithValue("@Phone", Phone);
        comm.Parameters.AddWithValue("@Email", Email);
        comm.Parameters.AddWithValue("@Facebook", Facebook);
        comm.Parameters.AddWithValue("@Cellphone", Cellphone);

        try
        {
            Conn.Open();
            int intRecords = comm.ExecuteNonQuery();
            strResult = "SUCCESS: Inserted " + intRecords + " records.";
            Conn.Close();
        }
        catch (Exception err)
        {
            strResult = "ERROR: " + err.Message;
        }
        finally
        {

        }
        return strResult;
    }

    public DataSet SearchPersons(String strFName, String strLName)
    {

        DataSet ds = new DataSet();



        SqlCommand comm = new SqlCommand();



        String strSQL = "SELECT PeopleID, FName, LName FROM Persons WHERE 0=0";

        if (strFName.Length > 0)
        {
            strSQL += " AND FName LIKE @FName";
            comm.Parameters.AddWithValue("@FName", "%" + strFName + "%");
        }
        if (strLName.Length > 0)
        {
            strSQL += " AND LName LIKE @LName";
            comm.Parameters.AddWithValue("@LName", "%" + strLName + "%");
        }



        SqlConnection conn = new SqlConnection();

        string strConn = @Connection();
        conn.ConnectionString = strConn;


        comm.Connection = conn;     
        comm.CommandText = strSQL;  


        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = comm; 

        conn.Open();               
        da.Fill(ds, "PersonV2_Temp");   
        conn.Close();        

  
        return ds;
    }

    public SqlDataReader FindOnePerson(int intPeopleID)
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

 
        string strConn = Connection();

   
        string sqlString =
       "SELECT * FROM Persons WHERE PeopleID = @PeopleID;";

 
        conn.ConnectionString = strConn;


        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("PeopleID", intPeopleID);


        conn.Open();


        return comm.ExecuteReader();  

    }

    public string DeleteOnePerson(int intPeopleID)
    {
        Int32 intRecords = 0;
        string strResult = "";

 
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();


        string strConn = Connection();

   
        string sqlString =
       "DELETE FROM Persons WHERE PeopleID = @PeopleID;";


        conn.ConnectionString = strConn;


        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@PeopleID", intPeopleID);

        try
        {
            conn.Open();


            intRecords = comm.ExecuteNonQuery();
            strResult = intRecords.ToString() + " Records Deleted.";
        }
        catch (Exception err)
        {
            strResult = "ERROR: " + err.Message;              
        }
        finally
        {
            conn.Close();
        }

        return strResult;


    }


    public string UpdateAPerson()
    {
        Int32 intRecords = 0;
        string strResult = "";

        string strSQL = "UPDATE Persons SET FName = @FName, MName = @MName, LName = @LName, StreetOne = @StreetOne, Streettwo = @StreetTwo, City = @City, State = @State, ZipCode = @ZipCode, Phone = @Phone, Email = @Email, Facebook = @Facebook, Cellphone = @Cellphone  WHERE PeopleID = @PeopleID;";


        SqlConnection conn = new SqlConnection();

        string strConn = Connection();
        conn.ConnectionString = strConn;


        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL;  
        comm.Connection = conn;

		comm.Parameters.AddWithValue("@PeopleID", PeopleID);
		comm.Parameters.AddWithValue("@FName", FName);
        comm.Parameters.AddWithValue("@MName", MName);
        comm.Parameters.AddWithValue("@LName", LName);
        comm.Parameters.AddWithValue("@StreetOne", StreetOne);
        comm.Parameters.AddWithValue("@StreetTwo", StreetTwo);
        comm.Parameters.AddWithValue("@City", City);
        comm.Parameters.AddWithValue("@State", State);
        comm.Parameters.AddWithValue("@ZipCode", ZipCode);
        comm.Parameters.AddWithValue("@Phone", Phone);
        comm.Parameters.AddWithValue("@Email", Email);
        comm.Parameters.AddWithValue("@Facebook", Facebook);
        comm.Parameters.AddWithValue("@Cellphone", Cellphone);

        try
        {

            conn.Open();

 
            intRecords = comm.ExecuteNonQuery();
            strResult = intRecords.ToString() + " Records Updated.";
        }
        catch (Exception err)
        {
            strResult = "ERROR: " + err.Message;           
        }
        finally
        {

            conn.Close();
        }

        return strResult;

    }


    public PersonV2(): base()
    {

        cellphone = "";
        facebook = "";

    }
}