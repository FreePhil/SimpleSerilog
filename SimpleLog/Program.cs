using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Enrichers.CallerInfo;
using Serilog.Events;
using Serilog.Exceptions;
using Serilog.Formatting.Compact;
using Serilog.Formatting.Json;
using Serilog.Sinks.MariaDB;
using Serilog.Sinks.MariaDB.Extensions;

namespace SimpleLog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.WithCallerInfo(includeFileInfo: true, assemblyPrefix: "SimpleLog")
                .WriteTo.Console(
                    restrictedToMinimumLevel: LogEventLevel.Information,
                    outputTemplate: "[{Timestamp:HH:mm:ss.fff} {Level:u3}] {Message:lj} [{SourceContext}::{Method}():{LineNumber}]{NewLine}{Exception}"
                )
                .WriteTo.File(
                    "SimpleLog.txt",
                    restrictedToMinimumLevel: LogEventLevel.Debug,
                    outputTemplate: "[{Timestamp:HH:mm:ss.fff} {Level:u3}] {Message:lj} [{SourceContext}.{Method}:{LineNumber}]{NewLine}{Exception}"
                    )
                .WriteTo.MariaDB(
                    connectionString: "server=localhost;user id=root;password=sample;database=logs",
                    tableName: "WeatherLogs",
                    restrictedToMinimumLevel: LogEventLevel.Debug,
                    autoCreateTable: true,
                    options: new MariaDBSinkOptions
                    {
                        ExcludePropertiesWithDedicatedColumn = false
                    }
                    )
                .CreateLogger();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
                .UseSerilog();
    }
}