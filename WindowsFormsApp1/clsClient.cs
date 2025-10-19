using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    internal class clsClient
    {private bool markForDelete = false;


        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string accountId { get; }
        public string phone { get; set; }
        public string memberShipName { get; set; }
        public clsClient(string firstName,string lastName,string email,string
            accountId,string phone,string memberShipName) { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.accountId = accountId;
            this.phone = phone;
            this.memberShipName = memberShipName;
        }
        private static clsClient _ConvertLineToObject(string line)
        {
            string[] obj = line.Split(GlobalVars.sep);
            clsClient client = new clsClient(obj[0], obj[1], obj[2], obj[3], obj[4], obj[5]);
            return client;
        }
        private string _ConvertObjectToLine(clsClient Client)
        {
            string line = Client.firstName + GlobalVars.sep;
            line += Client.lastName + GlobalVars.sep;
            line += Client.email + GlobalVars.sep;
            line += Client.accountId + GlobalVars.sep;
            line += Client.phone + GlobalVars.sep;
            line += Client.memberShipName;
            return line;
        }
        private static List<clsClient> _LoadClientDataFromFile()
        {
            string line;
            List<clsClient> LUsers = new List<clsClient>();
            FileStream MyFile = new FileStream(GlobalVars.ClientsFile, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(MyFile);
            while ((line = SR.ReadLine()) != null)
            {
                LUsers.Add(_ConvertLineToObject(line));
            }
            SR.Close();
            MyFile.Close();
            return LUsers;
        }
        private void _SaveClientDataToFile(List<clsClient> clientList)
        {
            FileStream myfile = new FileStream(GlobalVars.ClientsFile,FileMode.Create,FileAccess.Write); 
            StreamWriter SR = new StreamWriter(myfile);
            foreach (clsClient client in clientList) {
                if (client.markForDelete == false)
                {
                    string line = _ConvertObjectToLine(client);
                    SR.WriteLine(line);
                }
                
            }
            SR.Close ();
            myfile.Close();
            
        }
        private void _AddNewClient(clsClient client)
        {
            string line = _ConvertObjectToLine(client);
            FileStream MyFile = new FileStream(GlobalVars.ClientsFile, FileMode.Append,FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(MyFile);
            streamWriter.WriteLine(line);
            streamWriter.Close();
            MyFile.Close();
            
        }
        public static clsClient Find(string Id)
        {
            List<clsClient> LClients = _LoadClientDataFromFile();
            foreach (var client in LClients)
            {
                if (client.accountId == Id)
                {
                    return client;
                }
            }
            return null;
        }
        public static bool IsClientExist(string Id)
        {
            if (Find(Id) == null) return false;
            return true;
        }
        public void AddNew()
        {
            _AddNewClient(this);
        }
        public void Remove()
        {
            List<clsClient> LClients = _LoadClientDataFromFile();
            foreach (var client in LClients)
            {
                if (this.accountId == client.accountId) {
                    client.markForDelete = true;
                }
            }
            _SaveClientDataToFile(LClients);
        }

    }
}
