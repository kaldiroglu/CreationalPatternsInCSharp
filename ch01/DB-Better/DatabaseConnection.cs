namespace Dev.Kaldiroglu.Dp.Creational.Ch01.Db.Better
{
    public sealed class DatabaseConnection
    {
        // Read-only properties (immutability-friendly)
        public string Host { get; }
        public int Port { get; }
        public string Database { get; }
        public string Username { get; }
        public string Password { get; }
        public bool UseSsl { get; }
        public int ConnectionTimeout { get; }
        public int ReadTimeout { get; }
        public string Charset { get; }
        public bool AutoReconnect { get; }
        public int MaxRetries { get; }
        public string? ConnectionPool { get; }
        public bool EnableLogging { get; }
        public string LogLevel { get; }
        public string? Timezone { get; }

        private DatabaseConnection(Builder b)
        {
            Host = b.Host;
            Port = b.Port;
            Database = b.Database;
            Username = b.Username;
            Password = b.Password;
            UseSsl = b.UseSsl;
            ConnectionTimeout = b.ConnectionTimeout;
            ReadTimeout = b.ReadTimeout;
            Charset = b.Charset;
            AutoReconnect = b.AutoReconnect;
            MaxRetries = b.MaxRetries;
            ConnectionPool = b.ConnectionPool;
            EnableLogging = b.EnableLogging;
            LogLevel = b.LogLevel;
            Timezone = b.Timezone;
        }

        // Entry point: required fields
        public static Builder Create(string host, string database, string username, string password) =>
            new Builder(host, database, username, password);

        public sealed class Builder
        {
            // Required (init via ctor)
            public string Host { get; }
            public string Database { get; }
            public string Username { get; }
            public string Password { get; }

            // Optional with defaults
            public int Port { get; private set; } = 3306;
            public bool UseSsl { get; private set; } = true;
            public int ConnectionTimeout { get; private set; } = 30_000;
            public int ReadTimeout { get; private set; } = 60_000;
            public string Charset { get; private set; } = "UTF-8";
            public bool AutoReconnect { get; private set; } = true;
            public int MaxRetries { get; private set; } = 3;
            public string? ConnectionPool { get; private set; }
            public bool EnableLogging { get; private set; } = false;
            public string LogLevel { get; private set; } = "INFO";
            public string? Timezone { get; private set; }

            internal Builder(string host, string database, string username, string password)
            {
                Host = host;
                Database = database;
                Username = username;
                Password = password;
            }

            public Builder PortNumber(int port) { Port = port; return this; }
            public Builder UseSslEnabled(bool useSsl) { UseSsl = useSsl; return this; }
            public Builder ConnectionTimeoutMs(int ms) { ConnectionTimeout = ms; return this; }
            public Builder ReadTimeoutMs(int ms) { ReadTimeout = ms; return this; }
            public Builder CharsetName(string charset) { Charset = charset; return this; }
            public Builder AutoReconnectEnabled(bool enabled) { AutoReconnect = enabled; return this; }
            public Builder MaxRetriesCount(int retries) { MaxRetries = retries; return this; }
            public Builder ConnectionPoolName(string pool) { ConnectionPool = pool; return this; }
            public Builder EnableLoggingFlag(bool enabled) { EnableLogging = enabled; return this; }
            public Builder LogLevelName(string logLevel) { LogLevel = logLevel; return this; }
            public Builder TimezoneName(string timezone) { Timezone = timezone; return this; }

            public DatabaseConnection Build()
            {
                if (string.IsNullOrWhiteSpace(Host)) throw new ArgumentException("Host must not be blank");
                if (string.IsNullOrWhiteSpace(Database)) throw new ArgumentException("Database must not be blank");
                if (string.IsNullOrWhiteSpace(Username)) throw new ArgumentException("Username must not be blank");
                if (Password is null) throw new ArgumentException("Password must not be null");

                if (Port <= 0) throw new ArgumentException("Port must be > 0");
                if (ConnectionTimeout < 0) throw new ArgumentException("ConnectionTimeout must be >= 0");
                if (ReadTimeout < 0) throw new ArgumentException("ReadTimeout must be >= 0");
                if (MaxRetries < 0) throw new ArgumentException("MaxRetries must be >= 0");

                return new DatabaseConnection(this);
            }
        }
    }
}