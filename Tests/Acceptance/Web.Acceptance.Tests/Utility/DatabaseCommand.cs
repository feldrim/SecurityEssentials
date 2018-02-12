using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace SecurityEssentials.Acceptance.Tests.Utility
{
    public static class DatabaseCommand
    {
        public static void Execute(string resourceName)
        {
            using (var connection =
                new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString()))
            {
                string script;
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        script = reader.ReadToEnd();
                    }
                }

                var command = new SqlCommand(script, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}