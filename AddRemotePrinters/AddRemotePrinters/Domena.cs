using System.Collections.Generic;
using System.Linq;
using System.DirectoryServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Management;
using System.Security;
using System.Threading.Tasks;

namespace AddRemotePrinters
{
    class Domena
    {
         public List<string> PobierzKomputery(string nazwaDomeny)
        {
            List<string> ComputerNames = new List<string>();
            try {
                DirectoryEntry entry = new DirectoryEntry("LDAP://" + nazwaDomeny.ToString());
                DirectorySearcher mySearcher = new DirectorySearcher(entry);
                mySearcher.Asynchronous = true;

                mySearcher.Filter = ("(objectClass=computer)");
                mySearcher.SizeLimit = int.MaxValue;
                mySearcher.PageSize = int.MaxValue;

                foreach (SearchResult resEnt in mySearcher.FindAll())
                {
                    //"CN=SGSVG007DC"
                    string ComputerName = resEnt.GetDirectoryEntry().Name;
                    if (ComputerName.StartsWith("CN="))
                        ComputerName = ComputerName.Remove(0, "CN=".Length);
                    ComputerNames.Add(ComputerName);
                }

                mySearcher.Dispose();
                entry.Dispose();
                ComputerNames = ComputerNames.OrderBy(q => q).ToList();//sortujemy komputery
            }
            catch (COMException e)
            {
                MessageBox.Show("Problem wykonania połączenia: " + e.Message);

            }

            return ComputerNames;
        }
       
              private string nazwaDomeny;
        #pragma warning disable //Wyłączenie ostrzeżenia
        public new string NazwaDomeny
       {
            set
            {
                
              nazwaDomeny = value;
            }
            get
            {
                nazwaDomeny = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
                return nazwaDomeny;
            }
        }

        public SecureString ConvertToSecureString(string password)
        {
            if (password == null)
                throw new System.ArgumentNullException("password");

            var securePassword = new SecureString();

            foreach (char c in password)
                securePassword.AppendChar(c);

            securePassword.MakeReadOnly();
            return securePassword;
        }
    }

  
    
}
