using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Security.AccessControl;
using System.Security.Authentication;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace RLTrading.Model
{
    /// <summary>
    /// Json Saver
    /// </summary>
    public class JsonSaver : ISaver
    {
        #region Property

        /// <summary>
        /// Pfad bis Json Datei
        /// </summary>
        public static string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                    @"\RLTrading\data";
        /// <summary>
        /// Pfad bis und mit Json Datei
        /// </summary>
        public static string PathWithFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                            @"\RLTrading\data\Trades.json";
        #endregion

        #region Methoden

        /// <summary>
        /// Ladet alle Trades von der Json datei(siehe Property "path") in eine ObservableCollection
        /// </summary>
        /// <returns>ObservableCollection mit allen Trades</returns>
        public ObservableCollection<Trade> loadTrades()
        {
            try
            {
                if (!File.Exists(PathWithFile))
                {
                    this.GrantAccess(Path);
                    var f = File.Create(PathWithFile);
                    f.Close();
                }
                using (StreamReader r = new StreamReader(PathWithFile))
                {
                    string json = r.ReadToEnd();
                    if (json == "")
                    {
                        return new ObservableCollection<Trade>();
                    }

                    var jsonresult = JsonConvert.DeserializeObject<ObservableCollection<Trade>>(json);
                    return jsonresult;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nApplikation wird beendet!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
                return null;
            }
        }

        /// <summary>
        /// Speicher alle Trades in der Json Datei(siehe Property "path")
        /// </summary>
        /// <param name="allTrades">ObservableCollection mit den zu speichernden Trades</param>
        /// <returns>True / False je nach erfolg</returns>
        public async Task<bool> saveTradesAsync(ObservableCollection<Trade> allTrades)
        {
            try
            {
                using (StreamWriter w = new StreamWriter(PathWithFile, false))
                {
                    string json = JsonConvert.SerializeObject(allTrades);
                    await w.WriteAsync(json);
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
            DirectoryInfo di = System.IO.Directory.CreateDirectory(file);
            DirectoryInfo dInfo = new DirectoryInfo(file);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.Modify, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }

        #endregion
    }
}
