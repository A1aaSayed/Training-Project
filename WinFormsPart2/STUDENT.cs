using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsPart2
{
    internal class STUDENT
    {
        MY_DB db = new MY_DB();
        // create a function to a new student to the database
        public bool insertStudent(string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`first_name`, `last_name`, `birthdate`, `phone`, `address`, `picture`) VALUES (@fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", db.getConnection);
            // @fn, @ln, @bdt, @gdr, @phn, @adrs, @pic
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray();

            db.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection( );
                return false;
            }
        }

        // create a function to return a table of students data
        public DataTable getStudents(MySqlCommand command)
        {
            command.connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
