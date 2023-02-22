using System.Text;

namespace Alb.OpenPlayConnect.RemoteConfigs.ADO
{
    public static class Util
    {
        public static async Task<string?> ReadConfigFileAsync(string userAgent, string jsonfile)
        {
            var path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "api\\v1\\OTT\\STB\\" + userAgent + "\\config\\" + jsonfile);
            if (!File.Exists(path))
                return null;
            string json = await File.ReadAllTextAsync(path, Encoding.UTF8);
            return json;
        }

        public static async Task<string?> ReadConfigVersionFileAsync(string userAgent, string folder, string jsonfile)
        {
            var path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "api\\v1\\OTT\\STB\\" + userAgent + "\\" + folder + "\\config\\" + jsonfile);
            if (!File.Exists(path))
                return null;

            string json = await File.ReadAllTextAsync(path, Encoding.UTF8);
            return json;
        }

    }
}
