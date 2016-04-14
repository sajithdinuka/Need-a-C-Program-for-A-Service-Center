using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace SevenStarServiceCenter.Database
{
    public class dbaseClass
    {
        public SqlConnection sqlconn;
        public SqlDataAdapter sqlDA;
        public string connString = "";
        public static string loginName;//for use username as public
       
        public void databaseconnect()
        {
            try
            {
                string dirPath = "\\SevenStarServiceCenter\\SevenStarServiceCenter\\Resources\\";

                string filePath = dirPath + "connText.txt";

                FileStream fs = null;

                string line;

                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);

                StreamReader sr = new StreamReader(fs);

                while (sr.Peek() != -1)//peek read the strean reader lines while it's not equels to -1
                {
                    line = sr.ReadLine();

                    if (line.Trim() != string.Empty)
                    {
                        connString = line;

                    }
                }

                sr.Close();

                sqlconn = new SqlConnection(connString);

                sqlconn.Open();
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }     
    }
}
