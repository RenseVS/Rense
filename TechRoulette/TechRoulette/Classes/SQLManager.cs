using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TechRoulette.Classes
{
    class SQLManager
    {
        private string datasourceSQL;
        private string portSQL;
        private string userNameSQL;
        private string passWordSQL;
        private string mySQLConnection;
        private List<string> Inzet;
        private List<string> Vakje;
        private List<string> UserID;
        private List<string> Top10;
        private List<string> Winners;
        private string lastbetID;

        public SQLManager()
        {
            Inzet = new List<string>();
            Vakje = new List<string>();
            UserID = new List<string>();
            Top10 = new List<string>();
            Winners = new List<string>();
            datasourceSQL = "192.168.15.150;";
            portSQL = "3306;";
            userNameSQL = "rense;";
            passWordSQL = "P@ssw0rd";
            UpdatemySQLConnection();
        }

        private void UpdatemySQLConnection()
        {
            mySQLConnection = "datasource=" + datasourceSQL + "port=" + portSQL + "username=" + userNameSQL + "password=" + passWordSQL;
        }

        public void UpdatemySQLConnection(string Connectionstring)
        {
            mySQLConnection = Connectionstring;
        }
        //spelverloop
        public void LastBet()
        {
            try
            {
                lastbetID = "0";
                string sqlQuery = "SELECT MAX(inzetID) FROM UserRegistration.UserInzet";
                MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                MyConn.Open();
                MySqlDataReader dataReader = myCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    lastbetID = dataReader["MAX(inzetID)"].ToString();
                }
                MyConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
                Console.WriteLine(exception);
            }
        }
        public List<string> RetrieveUserID(string winner, string color, string Column, string row, string half, string even)
        {

            try
            {
                string sqlQuery = "SELECT * FROM UserRegistration.UserInzet WHERE inzetID <= " + lastbetID + " AND (inzetVakje = '" + winner + "' OR inzetVakje = '" + color + "' OR inzetVakje = '" + Column + "' OR inzetVakje = '" + row + "' OR inzetVakje = '" + half + "' OR inzetVakje = '" + even + "')";
                MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                MyConn.Open();
                MySqlDataReader dataReader = myCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    UserID.Add(dataReader["userID"].ToString());
                }
                MyConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
                Console.WriteLine(exception);
            }
            return UserID;
        }
        public List<string> RetrieveInzet(string winner, string color, string Column, string row, string half, string even)
        {
            try
            {
                string sqlQuery = "SELECT * FROM UserRegistration.UserInzet WHERE inzetID <= " + lastbetID + " AND inzetVakje = '" + winner + "' OR inzetVakje = '" + color + "' OR inzetVakje = '" + Column + "' OR inzetVakje = '" + row + "' OR inzetVakje = '" + half + "' OR inzetVakje = '" + even + "'";
                MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                MyConn.Open();
                MySqlDataReader dataReader = myCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Inzet.Add(dataReader["inzetAantal"].ToString());
                }
                MyConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
                Console.WriteLine(exception);
            }
            return Inzet;
        }
        public List<string> RetrieveVakje(string winner, string color, string Column, string row, string half, string even)
        {

            try
            {
                string sqlQuery = "SELECT * FROM UserRegistration.UserInzet WHERE inzetID <= " + lastbetID + " AND (inzetVakje = '" + winner + "' OR inzetVakje = '" + color + "' OR inzetVakje = '" + Column + "' OR inzetVakje = '" + row + "' OR inzetVakje = '" + half + "' OR inzetVakje = '" + even + "')";
                MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                MyConn.Open();
                MySqlDataReader dataReader = myCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Vakje.Add(dataReader["inzetVakje"].ToString());
                }
                MyConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
                Console.WriteLine(exception);
            }
            return Vakje;
        }
        public List<string> RetrieveUsers(List<int> UserID)
        {
            foreach (int ID in UserID)
            {
                try
                {
                    string sqlQuery = "SELECT username FROM UserRegistration.userReg WHERE userID = " + ID;
                    MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                    MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                    MyConn.Open();
                    MySqlDataReader dataReader = myCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Winners.Add(dataReader["username"].ToString());
                    }
                    MyConn.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(Convert.ToString(exception));
                    Console.WriteLine(exception);
                }
            }
            return Winners;
        }
        public void SendResults(List<int> UserID, List<int> Winst)
        {
            try
            {
                int i = 0;
                MySqlConnection MyConn = new MySqlConnection(mySQLConnection);

                MySqlDataReader dataReader;
                foreach (int ID in UserID)
                {
                    string sqlQuery = "UPDATE UserRegistration.userReg SET wallet = wallet + " + Winst[i] + " WHERE userID = " + UserID[i];
                    MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                    MyConn.Open();
                    dataReader = myCommand.ExecuteReader();
                    MyConn.Close();
                    i++;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
                Console.WriteLine(exception);
            }
        }
        public void SendData(string winner, string color, string Column, string row, string half, string even, int totaalWinst)
        {
            try
            {
                MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                string sqlQuery = "INSERT INTO UserRegistration.userWin (winNumber, winEvenOdd, winRow, winHalf, winColumn, winColor, winTotal) VALUES('" + winner + "', '" + even + "', '" + row + "', '" + half + "', '" + Column + "', '" + color + "', '" + totaalWinst + "')";
                MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                MyConn.Open();
                myCommand.ExecuteReader();
                MyConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
                Console.WriteLine(exception);
            }
        }
        public void GroteSchoonmaak()
        {
            UserID.Clear();
            Inzet.Clear();
            Vakje.Clear();
            Winners.Clear();
            try
            {
                string sqlQuery = "DELETE FROM UserRegistration.UserInzet WHERE inzetID <= " + lastbetID;
                MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                MyConn.Open();
                MySqlDataReader dataReader = myCommand.ExecuteReader();
                MyConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
                Console.WriteLine(exception);
            }
        }
        //Top10
        public List<string> RetrieveTop10()
        {
            try
            {
                string sqlQuery = "SELECT inzetVakje FROM UserRegistration.UserInzet GROUP BY inzetVakje ORDER BY COUNT(inzetAantal) DESC";
                MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                MyConn.Open();
                MySqlDataReader dataReader = myCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Top10.Add(dataReader["inzetVakje"].ToString());
                }
                MyConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
                Console.WriteLine(exception);
            }
            return Top10;
        }
        public void ResetLists()
        {
            Top10.Clear();
        }

        //Hot Data
        public string HotColumn()
        {
            string hotcolumn = "";
            try
            {
                string sqlQuery = "SELECT winColumn FROM UserRegistration.userWin GROUP BY winColumn ORDER BY COUNT(winColumn) DESC";
                MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                MyConn.Open();
                MySqlDataReader dataReader = myCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    hotcolumn = dataReader["winColumn"].ToString();
                }
                MyConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
                Console.WriteLine(exception);
            }
            return hotcolumn;
        }

        public string HotHalf()
        {
            {
                string hothalf = "";
                try
                {
                    string sqlQuery = "SELECT winHalf FROM UserRegistration.userWin GROUP BY winHalf ORDER BY COUNT(winHalf) DESC";
                    MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                    MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                    MyConn.Open();
                    MySqlDataReader dataReader = myCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        hothalf = dataReader["winHalf"].ToString();
                    }
                    MyConn.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(Convert.ToString(exception));
                    Console.WriteLine(exception);
                }
                return hothalf;
            }
        }

        public string HotRow()
        {
            {
                string hotrow = "";
                try
                {
                    string sqlQuery = "SELECT winRow FROM UserRegistration.userWin GROUP BY winRow ORDER BY COUNT(winRow) DESC";
                    MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                    MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                    MyConn.Open();
                    MySqlDataReader dataReader = myCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        hotrow = dataReader["winRow"].ToString();
                    }
                    MyConn.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(Convert.ToString(exception));
                    Console.WriteLine(exception);
                }
                return hotrow;
            }
        }

        public string HotEvenOdd()
        {
            {
                string hotevenodd = "";
                try
                {
                    string sqlQuery = "SELECT winEvenOdd FROM UserRegistration.userWin GROUP BY winEvenOdd ORDER BY COUNT(winEvenOdd) DESC";
                    MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                    MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                    MyConn.Open();
                    MySqlDataReader dataReader = myCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        hotevenodd = dataReader["winEvenOdd"].ToString();
                    }
                    MyConn.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(Convert.ToString(exception));
                    Console.WriteLine(exception);
                }
                return hotevenodd;
            }
        }

        public string HotNumber()
        {
            {
                string hotnumber = "";
                try
                {
                    string sqlQuery = "SELECT winNumber FROM UserRegistration.userWin GROUP BY winNumber ORDER BY COUNT(winNumber) DESC";
                    MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                    MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                    MyConn.Open();
                    MySqlDataReader dataReader = myCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        hotnumber = dataReader["winNumber"].ToString();
                    }
                    MyConn.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(Convert.ToString(exception));
                    Console.WriteLine(exception);
                }
                return hotnumber;
            }
        }
        public string HotColor()
        {
            string hotcolor = "";
            try
            {
                string sqlQuery = "SELECT winColor FROM UserRegistration.userWin GROUP BY winColor ORDER BY COUNT(winColor) DESC";
                MySqlConnection MyConn = new MySqlConnection(mySQLConnection);
                MySqlCommand myCommand = new MySqlCommand(sqlQuery, MyConn);
                MyConn.Open();
                MySqlDataReader dataReader = myCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    hotcolor = dataReader["winColor"].ToString();
                }
                MyConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
                Console.WriteLine(exception);
            }
            return hotcolor;
        }
    }
}
