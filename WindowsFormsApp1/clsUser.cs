using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class clsUser
    {
        public string userName { get; }
        public string password { get; set; }
        public string premission { get; set; }
        public string Name { get; set; }
        public clsUser(string userName,string password,string premission,string Name) { 
            this.userName = userName;
            this.password = password;
            this.premission = premission;
            this.Name = Name;

        }
        private static clsUser _ConvertLineToObject(string line)
        {
            string[]obj = line.Split(GlobalVars.sep);
            clsUser user = new clsUser(obj[0], obj[1], obj[2], obj[3]);
            return user;
        }

        private static List<clsUser> _LoadClientDataFromFile()
        {
            string line;
            List<clsUser> LUsers = new List<clsUser>();
            FileStream MyFile = new FileStream(GlobalVars.UsersFile, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(MyFile);
            while ((line = SR.ReadLine()) != null) { 
                LUsers.Add(_ConvertLineToObject(line));
            }
            SR.Close();
            MyFile.Close();
            return LUsers;
        }
        private string _ConvertObjectToLine(clsUser User)
        {
            string line = User.userName + GlobalVars.sep;
            line += User.password + GlobalVars.sep;
            line += User.premission + GlobalVars.sep;
            line += User.Name;
            return line;
        }
        private void _AddNewClient(clsUser User)
        {
            string line = _ConvertObjectToLine(User);
            FileStream MyFile = new FileStream(GlobalVars.UsersFile, FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(MyFile);
            streamWriter.WriteLine(line);
            streamWriter.Close();
            MyFile.Close();

        }
        public static clsUser Find(string UserName,string Password)
        {
            List<clsUser> LUsers = _LoadClientDataFromFile();
            foreach (var client in LUsers)
            {
                if(client.userName == UserName && client.password == Password)
                {
                    return client;
                }
            }
            return null;

        }
        public static clsUser Find(string UserName)
        {
            List<clsUser> LUsers = _LoadClientDataFromFile();
            foreach (var client in LUsers)
            {
                if (client.userName == UserName )
                {
                    return client;
                }
            }
            return null;

        }
        public void AddNew()
        {
            _AddNewClient(this);
        }
        public static bool IsClientExist(string UserName,string Password)
        {
            if (Find(UserName,Password) == null)
                return false;
            return true;
        }
    }
}
