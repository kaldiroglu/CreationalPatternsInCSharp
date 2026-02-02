namespace Dev.Kaldiroglu.Dp.Creational.Ch01.Db.Better
{
    public sealed class Test
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Dev.Kaldiroglu.Dp.Creational.Ch01.Db.Better.Test");
            const int PostgresPort = 5432;
            const int ProdConnectionTimeoutMs = 10_000;
            const int ProdReadTimeoutMs = 120_000;
            const int AnalyticsReadTimeoutMs = 300_000; // 5 minutes for long queries

            const string Utf8 = "UTF-8";
            const string HikariCp = "HikariCP";
            const string Utc = "UTC";
            const string Debug = "DEBUG";

            static DatabaseConnection CreateConnection(
                string host,
                string database,
                string username,
                string password,
                Action<DatabaseConnection.Builder>? configure = null)
            {
                var builder = DatabaseConnection.Create(host, database, username, password);
                configure?.Invoke(builder);
                return builder.Build();
            }

            var devConnection = CreateConnection(
                host: "localhost",
                database: "myapp_dev",
                username: "dev_user",
                password: "<dev_password>");

            var productionConnection = CreateConnection(
                host: "prod-db-cluster.company.com",
                database: "myapp_production",
                username: "prod_user",
                password: "<prod_password>",
                configure: b => b
                    .PortNumber(PostgresPort) // PostgreSQL
                    .UseSslEnabled(true)
                    .ConnectionTimeoutMs(ProdConnectionTimeoutMs)
                    .ReadTimeoutMs(ProdReadTimeoutMs)
                    .ConnectionPoolName(HikariCp)
                    .EnableLoggingFlag(true));

            var testConnection = CreateConnection(
                host: "test-server",
                database: "test_db",
                username: "test_user",
                password: "<test_password>",
                configure: b => b
                    .UseSslEnabled(false)
                    .CharsetName(Utf8)
                    .AutoReconnectEnabled(false));

            var analyticsConnection = CreateConnection(
                host: "analytics-db",
                database: "warehouse",
                username: "analytics_user",
                password: "<analytics_password>",
                configure: b => b
                    .TimezoneName(Utc)
                    .EnableLoggingFlag(true)
                    .LogLevelName(Debug)
                    .ReadTimeoutMs(AnalyticsReadTimeoutMs));
        }
    }
}