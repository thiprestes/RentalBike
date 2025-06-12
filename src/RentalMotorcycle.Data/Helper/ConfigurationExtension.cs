using Microsoft.Extensions.Configuration;

namespace RentalMotorcycle.Data.Helper;

public static class ConfigurationExtension
{
    private const string PostgresUsernameEnvVar = "POSTGRES_USERNAME";
    private const string PostgresPasswordEnvVar = "POSTGRES_PASSWORD";
    private const string PostgresConnectionStringProperty = "DefaultConnection";

    #region Exceptions

    private const string ErrorSettingsNotFoundLog = "Could not locate the environment variable: \"{0}\"";

    #endregion

    public static string EnsureValue(
        this IConfiguration configuration,
        string key)
    {
        return configuration[key]
               ?? throw new Exception(ErrorSettingsNotFoundLog.FormatWith(key));
    }

    public static string EnsureConnectionString(
        this IConfiguration configuration,
        string key)
    {
        return configuration.GetConnectionString(key)
               ?? throw new Exception(ErrorSettingsNotFoundLog.FormatWith(key));
    }
    
    public static string GetConnectionStringPostgres(this IConfiguration configuration, string schema)
    {
        var postgresUsername = configuration.EnsureValue(PostgresUsernameEnvVar);
        var postgresPassword = configuration.EnsureValue(PostgresPasswordEnvVar);
        var connectionString = configuration.EnsureConnectionString(PostgresConnectionStringProperty).FormatWith(postgresUsername, postgresPassword);
        AddSchemaNameIfNotExists(connectionString, schema);

        return connectionString;
    }
    
    private static string AddSchemaNameIfNotExists(string connString, string schemaName)
    {
        if (connString.Contains(";SearchPath="))
        {
            return connString;
        }

        if (!connString.EndsWith(";"))
        {
            connString += ";";
        }
        connString += "SearchPath=" + schemaName;

        return connString;
    }
}