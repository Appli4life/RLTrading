using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Authentication;
using System.Security.Principal;
using System.Windows;

namespace RLTrading.Model
{
    public class JsonTradeRepository : ITradeRepository
    {
        private readonly JsonFormater jsonFormater;

        private string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            @"\RLTrading\data";
        /// <summary>
        /// Pfad bis und mit Json Datei
        /// </summary>
        private string PathWithFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                            @"\RLTrading\data\Trades.json";

        public JsonTradeRepository()
        {
            this.jsonFormater = new JsonFormater();
        }

        public JsonTradeRepository(string path, string fileName = "Trades.json")
        : this()
        {
            this.Path = path;
            this.PathWithFile = path + @"\" + fileName;
        }

        public ObservableCollection<Trade> loadTrades()
        {
            try
            {
                if (!File.Exists(PathWithFile))
                {
                    GrantAccess(Path);
                    var f = File.Create(PathWithFile);
                    f.Close();
                }
                using (var r = new StreamReader(PathWithFile))
                {
                    var json = r.ReadToEnd();
                    if (json == "")
                    {
                        return new ObservableCollection<Trade>();
                    }

                    return jsonFormater.DeserializeTrade(json);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nApplikation wird beendet!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
                return null;
            }
        }

        public bool SaveTrades(IEnumerable<Trade> trades)
        {
            try
            {
                using (var w = new StreamWriter(PathWithFile, false))
                {
                    var json = jsonFormater.SerializeTrade(trades);
                    w.Write(json);
                }

                return true;
            }
            catch (AuthenticationException ae)
            {
                MessageBox.Show(ae.Message, "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        /// <summary>
        /// Set full Control to Everyone
        /// </summary>
        /// <param name="file">Zu welchem file</param>
        private void GrantAccess(string file)
        {
            var di = Directory.CreateDirectory(file);
            var dInfo = new DirectoryInfo(file);
            var dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.Modify, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }
    }
}
