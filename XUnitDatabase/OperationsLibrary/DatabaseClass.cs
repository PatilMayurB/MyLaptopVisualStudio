using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsLibrary
{
    public class DatabaseClass
    {
        static SqlConnection con = null;
        public static int saveName(string firstName, string lastName)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UserDetails;Integrated Security=True;Pooling=False";
                con.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.CommandText = "Insert into namedata values (@firstname, @lastname)";
                sqlCommand.Parameters.AddWithValue("firstname", firstName);
                sqlCommand.Parameters.AddWithValue("lastname", lastName);

                int i = sqlCommand.ExecuteNonQuery();

                if (i != 0)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return 0;
        }

        public static int retrieveName(string firstName, string lastName)
        {
            //string name = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UserDetails;Integrated Security=True;Pooling=False";
                con.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.CommandText = "select * from namedata where firstname = @firstname and lastname = @lastname";
                sqlCommand.Parameters.AddWithValue("firstname", firstName);
                sqlCommand.Parameters.AddWithValue("lastname", lastName);

                SqlDataReader data = sqlCommand.ExecuteReader();

                if (data.Read())
                {
                    //name = Convert.ToString(data["firstname"]) + " " + Convert.ToString(data["lastname"]);
                    //return name;
                    return 1;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            //return "empty";
            return 0;
        }


        public static List<string> retrieveAllNames()
        {
            List<string> allNames = new List<string>();
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UserDetails;Integrated Security=True;Pooling=False";
                con.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.CommandText = "select * from namedata";

                SqlDataReader data = sqlCommand.ExecuteReader();

                while (data.Read())
                {
                    allNames.Add(Convert.ToString(data["firstname"]) + " " + Convert.ToString(data["lastname"]));
                }
                return allNames;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return null;
        }

        //public static List<Person> retrieveAllNames()
        //{
        //    List<Person> allNames = new List<Person>();
        //    try
        //    {
        //        con = new SqlConnection();
        //        con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UserDetails;Integrated Security=True;Pooling=False";
        //        con.Open();

        //        SqlCommand sqlCommand = new SqlCommand();
        //        sqlCommand.Connection = con;
        //        sqlCommand.CommandType = CommandType.Text;

        //        sqlCommand.CommandText = "select * from namedata";

        //        SqlDataReader data = sqlCommand.ExecuteReader();

        //        if (data.Read())
        //        {
        //            foreach (Person name in data)
        //            {
        //                allNames.Add(new Person { FirstName = Convert.ToString(data["firstname"]), LastName = Convert.ToString(data["lastname"]) });
        //            }
        //            return allNames;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return null;
        //}
    }
}
