using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;

namespace MusicPlayer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //conectarea cu baza de date
            //SqlConn conn = new SqlConn("Server=DESKTOP-PP8AELH\\SQLEXPRESS01;Database=MusicPlayer;Trusted_Connection=True;");
            string configPath = Path.Combine(Application.StartupPath, "appsettings.json");
            string json = File.ReadAllText(configPath);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic config = serializer.DeserializeObject(json);

            string connectionString = config["ConnectionStrings"]["MusicPlayer"];

            SqlConn conn = new SqlConn(connectionString);
            Repository repository = new Repository(conn);///1
            Service service = new Service(repository);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LaunchScreenForm(service));
        }
    }
}
