using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back
{

    /// <summary>
    /// this class is used for all sql server queries
    /// each method is one query or repeated slightly altered queries
    /// functions like TruncateTest and MakeTest are always used together, but kept seperate for the simplicity of one query per function
    /// </summary>
    public class SQLConnect
    {
        string connetionString;
        SqlConnection connection;
        SqlCommand command;
        string sql;
        SqlDataReader dataReader;

        public SQLConnect()
        {
            connetionString = "Server=tcp:dv-server1234567.database.windows.net,1433;Initial Catalog=DVchoc;Persist Security Info=False;User ID=andredev1234567;Password=Kooler1234567;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection = new SqlConnection(connetionString);
        }

        //lecturer functions......................................................................................
        public bool ValidateLecturer(string name, string password)
        {
            bool noResultExists = true;
            sql = " select  *  from Lecturers  where name = '" + name + "' and password = '" + password + "'; ";

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                //if anything is returned the student is in the database
                if (dataReader.Read())
                {
                    noResultExists = false;
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch(Exception NoResuslts)
            {
                //fail to log in and no data found are the same thing, result will be the same
                noResultExists = true;
                Console.WriteLine("No result");
                Console.ReadKey();
            }
            return noResultExists;
        }


        public List<string[]> GetClassList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn;";

            
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }
            

            return classListSet;
        }

        public List<string[]> GetMbhathaList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Mbhatha';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetMufamadiList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Mufamadi';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetSekgotaList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Sekgota';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetHobyaneList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Hobyane';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetMzimkhuluList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Mzimkhulu';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetMasogoList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Masogo';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetNyamaList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Nyama';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetZuluList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Zulu';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetMonyebodiList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Monyebodi';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetKhatiList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Khati';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetDubeList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Dube';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetNgobeniList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Ngobeni';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetKomaneList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Komane';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetMatsitseList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Matsitse';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetMogotsiList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Mogotsi';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetRangaList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Ranga';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetMukwenaList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Mukwena';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetNtlavanaList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Ntlavana';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetBengeList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Benge';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetHufkeList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Hufke';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetRossList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Ross';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetSolomonsList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Solomons';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetMasekoList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Maseko';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetMbekwaList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Mbekwa';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetMpofuList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Mpofu';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }

        public List<string[]> GetCebeniList()
        {
            List<string[]> classListSet = new List<string[]> { };
            string[] classListRow;

            sql = "select * from tbl_ClockIn where fld_lastName='Cebeni';";


            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                classListRow = new string[15];

                //fld_id, fld_firstName, fld_lastName,fld_personalIDnumber, fld_deviceID, fld_latitube, fld_longitude, fld_dateTime
                //fld_id
                classListRow[0] = dataReader.GetValue(0).ToString();
                //fld_firstName
                classListRow[1] = dataReader.GetValue(1).ToString();
                //fld_lastName
                classListRow[2] = dataReader.GetValue(2).ToString();
                //fld_personalIDnumber
                classListRow[3] = dataReader.GetValue(3).ToString();
                //fld_deviceID
                classListRow[4] = dataReader.GetValue(4).ToString();
                //fld_latitube
                classListRow[5] = dataReader.GetValue(5).ToString();
                //fld_longitude
                classListRow[6] = dataReader.GetValue(6).ToString();
                //fld_dateTime
                classListRow[7] = dataReader.GetValue(7).ToString();
                //fld_dateTime
                classListRow[8] = dataReader.GetValue(8).ToString();
                //fld_dateTime
                classListRow[9] = dataReader.GetValue(9).ToString();
                //fld_dateTime
                classListRow[10] = dataReader.GetValue(10).ToString();
                //fld_dateTime
                classListRow[11] = dataReader.GetValue(11).ToString();
                //fld_dateTime
                classListRow[12] = dataReader.GetValue(12).ToString();
                //fld_dateTime
                classListRow[13] = dataReader.GetValue(13).ToString();
                //fld_dateTime
                classListRow[14] = dataReader.GetValue(14).ToString();


                classListSet.Add(classListRow);
            }


            return classListSet;
        }
        
        public bool AddLecturer(string name, string password)
        {
            sql = "insert into Lecturers(name,password) values ('" + name + "','" + password + "'); ";
            bool lecturerAdded;
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteScalar();
                command.Dispose();
                connection.Close();
                //if query works
                lecturerAdded = true;
            }
            catch (Exception NoResuslts)
            {
                //if query does not
                lecturerAdded = false;
                Console.WriteLine("No result");
                Console.WriteLine("No result");
                Console.ReadKey();
            }
            return lecturerAdded;
        }
        //END lecturer functions......................................................................................

        //Student functions......................................................................................
        public bool ValidateStudent(string name, string password)
        {
            bool noResultExists = true;
            sql = " select  *  from Students  where name = '" + name + "' and password = '" + password + "'; ";

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                //if anything is returned the student is in the database
                if (dataReader.Read())
                {
                    noResultExists = false;
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception NoResuslts)
            {
                //no data returns the same as invalid user
                noResultExists = true;
                Console.WriteLine("No result");
                Console.WriteLine("No result");
                Console.ReadKey();
            }

            return noResultExists;
        }

        public  bool AddStudentMark(string name, int studentMarks, int totalMarks)
        {
            sql = "insert into StudentMarks(name, correctAnswers, totalAnswers) values('" + name + "', "+studentMarks+", "+totalMarks+");";
            bool studentMark;
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteScalar();
                command.Dispose();
                connection.Close();
                //if query works
                studentMark = true;
            }
            catch (Exception NoResuslts)
            {
                //if query does not work
                studentMark = false;
                Console.WriteLine("No result");
                Console.WriteLine("No result");
                Console.ReadKey();
            }
            return studentMark;
        }
        //END Student functions......................................................................................



        //Test functions...................................................................................................
        public List<string[]> GetTest()
        {
            List<string[]> testSet = new List<string[]> { };
            string[] testRow;

            sql = " select *  from Test; ";

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    testRow = new string[6];

                    //question,a,b,c,d,correntAnswer from Test table in database
                    //question
                    testRow[0] = dataReader.GetValue(0).ToString();
                    //a
                    testRow[1] = dataReader.GetValue(1).ToString();
                    //b
                    testRow[2] = dataReader.GetValue(2).ToString();
                    //c
                    testRow[3] = dataReader.GetValue(3).ToString();
                    //d
                    testRow[4] = dataReader.GetValue(4).ToString();
                    //correctAnswer
                    testRow[5] = dataReader.GetValue(5).ToString();

                    testSet.Add(testRow);
                }


                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception NoResuslts)
            {

                //returns a list disconnected or not
                testRow = new string[6];

                //question,a,b,c,d,correntAnswer from Test table in database
                //question
                testRow[0] = "No Results Found";
                //a
                testRow[1] = "No Results Found";
                //b
                testRow[2] = "No Results Found";
                //c
                testRow[3] = "No Results Found";
                //d
                testRow[4] = "No Results Found";
                //correctAnswer
                testRow[5] = "No Results Found";

                testSet.Add(testRow);
                Console.WriteLine("No result");
                Console.WriteLine("No result");
                Console.ReadKey();
            }

            return testSet;
        }

        //this is an example of recursion
        //when the method is intialy called numCurrent is 0, as it calls itself numCurrent increments till it reaches testBuildBuffer.Count-1, since arrays start at 0 and testBuildBuffer.Count starts at 1
        public bool MakeTest(List<string[]> testBuildBuffer, int numCurrent)
        {
            int currentNum = numCurrent;
            //each query will insert a row into Test table, each row being one question
            string testRow = "insert into Test(question, a, b, c, d, correctAnswer) values('" + testBuildBuffer[currentNum][0] + "','" + testBuildBuffer[currentNum][1] + "','" + testBuildBuffer[currentNum][2] + "','" + testBuildBuffer[currentNum][3] + "','" + testBuildBuffer[currentNum][4] + "','" + testBuildBuffer[currentNum][5] + "');";
            bool rowInserted;

            try
            {
                connection.Open();

                command = new SqlCommand(testRow, connection);

                command.ExecuteScalar();
                command.Dispose();
                connection.Close();

                rowInserted = true;

                //if the end of testBuildBuffer has been reached the recursion will end
                if (currentNum < testBuildBuffer.Count - 1)
                {
                    MakeTest(testBuildBuffer, ++currentNum);
                }
            }
            catch (Exception NoResuslts)
            {
                //if query does not work
                rowInserted = false;
                Console.WriteLine("No result");
                Console.WriteLine("No result");
                Console.ReadKey();
            }

            return rowInserted;
        }

        public bool TruncateTest()
        {
            sql = "truncate table Test";
            bool testTruncated;

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteScalar();
                command.Dispose();
                connection.Close();
                testTruncated = true;
            }
            catch (Exception NoResuslts)
            {
                //if query does not work
                testTruncated = false;
                Console.WriteLine("No result");
                Console.WriteLine("No result");
                Console.ReadKey();
            }
            return testTruncated;

        }
        //END Test functions.............................................................................................


        //memo functions......................................................................................
        public bool TruncateMemo()
        {
            sql = "truncate table Memo";
            bool memoTruncated;

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteScalar();
                command.Dispose();
                connection.Close();
                memoTruncated = true;
            }
            catch (Exception NoResuslts)
            {
                //if query does not work
                memoTruncated = false;
                Console.WriteLine("No result");
                Console.WriteLine("No result");
                Console.ReadKey();
            }
            return memoTruncated;

        }

        public bool PopulateMemoWithTest()
        {
            sql = "insert into Memo(question, a, b, c, d, correctAnswer) select* from Test;";
            bool testPopulated;

            try { 
            connection.Open();
            command = new SqlCommand(sql, connection);
            command.ExecuteScalar();
            command.Dispose();
            connection.Close();
                testPopulated = true;
            }
        catch (Exception NoResuslts)
            {
                //if query does not work
                testPopulated = false;
                Console.WriteLine("No result");
                Console.WriteLine("No result");
                Console.ReadKey();
            }
            return testPopulated;
}

        //recursion 
        //when the method is intialy called numCurrent is 0, as it calls itself numCurrent increments till it reaches studentAnswers.Length-1, since arrays start at 0 and studentAnswers.Length starts at 1
        public bool AddStudentMarksToMemo(string[] studentAnswers, int numCurrent)
        {
            int currentNum = numCurrent;
            string sql = "UPDATE Memo SET studentAnswer = '" + studentAnswers[currentNum] + "' WHERE id = " + (currentNum+1) + ";";
            bool markAdded;
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteScalar();
                command.Dispose();
                connection.Close();
                markAdded = true;

                //if the end of studentAnswers has been reached the recursion will end
                if (currentNum < studentAnswers.Length - 1)
                {
                    AddStudentMarksToMemo(studentAnswers, ++currentNum);
                }
        }
            catch (Exception NoResuslts)
            {
                //if query does not work
                markAdded = false;
                Console.WriteLine("No result");
                Console.WriteLine("No result");
                Console.ReadKey();
            }
            return markAdded;

        }


        public bool AddStudentMarksToMemo(char[] studentAnswers, int numCurrent)
        {
            int currentNum = numCurrent;
            string sql = "UPDATE Memo SET studentAnswer = '" + studentAnswers[currentNum] + "' WHERE id = " + (currentNum + 1) + ";";
            bool markAdded;
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteScalar();
                command.Dispose();
                connection.Close();
                markAdded = true;

                //if the end of studentAnswers has been reached the recursion will end
                if (currentNum < studentAnswers.Length - 1)
                {
                    AddStudentMarksToMemo(studentAnswers, ++currentNum);
                }
            }
            catch (Exception NoResuslts)
            {
                //if query does not work
                markAdded = false;
                Console.WriteLine("No result");
                Console.WriteLine("No result");
                Console.ReadKey();
            }
            return markAdded;

        }


        public List<string[]> GetMemo()
        {
            List<string[]> memoSet = new List<string[]> { };
            string[] memoRow;

            sql = " select *  from Memo; ";
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    memoRow = new string[8];

                    //index here starts at 1 since index 0 is column numbers
                    //question,a,b,c,d,correntAnswer,studentAnswer from Memo table in database
                    //question
                    memoRow[1] = dataReader.GetValue(1).ToString();
                    //a
                    memoRow[2] = dataReader.GetValue(2).ToString();
                    //b
                    memoRow[3] = dataReader.GetValue(3).ToString();
                    //c
                    memoRow[4] = dataReader.GetValue(4).ToString();
                    //d
                    memoRow[5] = dataReader.GetValue(5).ToString();
                    //correctAnswer
                    memoRow[6] = dataReader.GetValue(6).ToString();
                    //studentAnswer
                    memoRow[7] = dataReader.GetValue(7).ToString();

                    memoSet.Add(memoRow);
                }

                dataReader.Close();
                command.Dispose();
                connection.Close();
                
            }
            catch (Exception NoResuslts)
            {
                memoRow = new string[8];

                //index here starts at 1 since index 0 is column numbers
                //question,a,b,c,d,correntAnswer,studentAnswer from Memo table in database
                //question
                memoRow[1] = "No Results Found";
                //a
                memoRow[2] = "No Results Found";
                //b
                memoRow[3] = "No Results Found";
                //c
                memoRow[4] = "No Results Found";
                //d
                memoRow[5] = "No Results Found";
                //correctAnswer
                memoRow[6] = "No Results Found";
                //studentAnswer
                memoRow[7] = "No Results Found";

                memoSet.Add(memoRow);
                Console.WriteLine("No result");
                Console.WriteLine("No result");
                Console.ReadKey();
            }
            return memoSet;
        }

        //END memo functions......................................................................................


        public List<string> GetCorrectAnswers()
        {
            List<string> correctAnswers = new List<string> { };

            sql = " select correctAnswer  from Memo; ";
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    string correctAnswer = "";

                    //correct answer stored
                    correctAnswer = dataReader.GetValue(0).ToString();

                    correctAnswers.Add(correctAnswer);
                }

                dataReader.Close();
                command.Dispose();
                connection.Close();

            }
            catch (Exception NoResuslts)
            {
               
            }
            return correctAnswers;
        }
    }
}


