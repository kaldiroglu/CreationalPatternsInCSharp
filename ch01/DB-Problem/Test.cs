namespace Dev.Kaldiroglu.Dp.Creational.Ch01.Db.Problem
{
    public sealed class Test
    {
        private static void Main(string[] args)
        {
        Console.WriteLine("Dev.Kaldiroglu.Dp.Creational.Ch01.Db.Problem.Test.Main");
        // Scenario 1: Basic local development connection
            var devConn = new DatabaseConnection();
            devConn.Host = "localhost";
            devConn.Database = "myapp_dev";
            devConn.Username = "dev_user";
            devConn.Password = "<dev_password>";

            // Scenario 2: Production connection with custom security and timeouts
            var prodConn = new DatabaseConnection();
            prodConn.Host = "prod-db-cluster.company.com";
            prodConn.Port = 5432; // PostgreSQL
            prodConn.Database = "myapp_production";
            prodConn.Username = "prod_user";
            prodConn.Password = "<prod_password>";
            prodConn.UseSSL = true;
            prodConn.ConnectionTimeout = 10_000;
            prodConn.ReadTimeout = 120_000;
            prodConn.ConnectionPool = "HikariCP";
            prodConn.EnableLogging = true;

            // Scenario 3: Testing connection with specific charset and no SSL
            var testConn = new DatabaseConnection();
            testConn.Host = "test-server";
            testConn.Database = "test_db";
            testConn.Username = "test_user";
            testConn.Password = "<test_password>";
            testConn.UseSSL = false;
            testConn.Charset = "UTF-8";
            testConn.AutoReconnect = false;

            // Scenario 4: Analytics connection with custom timezone and logging
            var analyticsConn = new DatabaseConnection();
            analyticsConn.Host = "analytics-db";
            analyticsConn.Database = "warehouse";
            analyticsConn.Username = "analytics_user";
            analyticsConn.Password = "<analytics_password>";
            analyticsConn.Timezone = "UTC";
            analyticsConn.EnableLogging = true;
            analyticsConn.LogLevel = "DEBUG";
            analyticsConn.ReadTimeout = 300_000; // 5 minutes for long queries
        }
    }
}