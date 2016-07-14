using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
//using Win32_printer;
namespace AddRemotePrinters
{
    class Drukarka
    {
        public void DodajDrukarke(string komputer,string drukarka,string parametr,string serwerWydruku)
        {

            Process p = new Process();
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.FileName = @"PsExec.exe";
            
             
            p.StartInfo.Arguments = @"\\"+ komputer + @" cmd /c (rundll32 printui.dll,PrintUIEntry "+ parametr  + @" /n \\"+serwerWydruku +@"\" + drukarka + @")";
            p.Start();
            
           
            
            
           
        }

        public List<string> PobierzDrukarki(string nazwaSerweraWydruku)
        {
            List<string> drukarkiPosortowane = new List<string>();
             try
            { //Nowe połączenie connetion - można spróbować ustawić dane do autoryzacji.
                ConnectionOptions connection = new ConnectionOptions();
                connection.Authority = "ntlmdomain:DOMAIN";
                ManagementScope scope = new ManagementScope(
                 "\\\\" + nazwaSerweraWydruku + "\\root\\cimv2");
           
            scope.Connect();
            ObjectQuery query = new ObjectQuery("SELECT Shared, ShareName FROM Win32_Printer");
           
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                ManagementObjectCollection queryCollection = searcher.Get();

                foreach (ManagementObject m in queryCollection)
                {
                    if (m["Shared"].Equals(true))
                    { drukarkiPosortowane.Add(m["ShareName"].ToString()); }
                }

                drukarkiPosortowane.OrderBy(q => q).ToList();

                return drukarkiPosortowane;
            }
            catch(COMException e)
            {
                MessageBox.Show("Problem wykonania połączenia: " + e.Message);

            }
            
             catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("Brak uprawnień do serwera wydruku: " + e.Message);

            }
            return null;

        }
       

        //Pobiera drukarki - parametr Nazwa Serwera Wydruku, Login
        public List<string> PobierzDrukarki(string nazwaSerweraWydruku,string userName,string password)
        {
            List<string> drukarkiPosortowane = new List<string>();
            try
            {
                ConnectionOptions connection = new ConnectionOptions();
               
                    connection.Username = userName;
                    connection.Password = password;
                    connection.Authority = "ntlmdomain:maspex.wadowice";
                                   
                ManagementScope scope = new ManagementScope(
                "\\\\" + nazwaSerweraWydruku + "\\root\\cimv2",connection);

                scope.Connect();
                ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_Printer");

                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                ManagementObjectCollection queryCollection = searcher.Get();

                foreach (ManagementObject m in queryCollection)
                {
                    drukarkiPosortowane.Add(m["ShareName"].ToString());
                }

                drukarkiPosortowane.OrderBy(q => q).ToList();

                return drukarkiPosortowane;
            }
            catch (COMException e)
            {
                MessageBox.Show("Problem wykonania połączenia: " + e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("Brak uprawnień do serwera wydruku: " + e.Message);
            }
            catch(Exception e)
            {
                MessageBox.Show("Brak uprawnień do serwera wydruku: " + e.Message);
            }
            return null;
        }
    }
}
