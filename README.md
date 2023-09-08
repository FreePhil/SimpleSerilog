# SimpleSerilog

### ASP.NET Core 3.1

### Additional Package
      <PackageReference Include="Serilog.AspNetCore" Version="6.1.0" />
      <PackageReference Include="Serilog.Enrichers.CallerInfo" Version="1.0.3" />
      <PackageReference Include="Serilog.Exceptions" Version="8.4.0" />

### Memo

#### configuration
    Programs.cs
#### log action
    Controllers/WeatherForecastController.cs


### Sample log content

```
[15:00:17.756 DBG] Random generator creates 0 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:17.761 INF] Get weather forecast, the first day: {"Date": "2023-09-09T15:00:17.7609554+08:00", "TemperatureC": -4, "TemperatureF": 25, "Summary": "Scorching", "$type": "WeatherForecast"} [SimpleLog.Controllers.WeatherForecastController::Get():60]
[15:00:18.335 DBG] Random generator creates 1 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:18.340 ERR] Radar in maintenance [SimpleLog.Controllers.WeatherForecastController::Get():53]
System.ApplicationException: Stop operation
   at SimpleLog.Controllers.WeatherForecastController.Get() in C:\Users\Phil\Desktop\dotnet\SimpleLog\SimpleLog\Controllers\WeatherForecastController.cs:line 53
[15:00:19.430 DBG] Random generator creates 9 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:19.434 WRN] Error should not exceed 5, current value: 9 [SimpleLog.Controllers.WeatherForecastController::Get():38]
[15:00:19.441 INF] Get weather forecast, the first day: {"Date": "2023-09-09T15:00:19.4410502+08:00", "TemperatureC": -7, "TemperatureF": 20, "Summary": "Balmy", "$type": "WeatherForecast"} [SimpleLog.Controllers.WeatherForecastController::Get():60]
[15:00:20.344 DBG] Random generator creates 6 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:20.348 WRN] Error should not exceed 5, current value: 6 [SimpleLog.Controllers.WeatherForecastController::Get():38]
[15:00:20.352 INF] Get weather forecast, the first day: {"Date": "2023-09-09T15:00:20.3518765+08:00", "TemperatureC": 33, "TemperatureF": 91, "Summary": "Mild", "$type": "WeatherForecast"} [SimpleLog.Controllers.WeatherForecastController::Get():60]
[15:00:21.305 DBG] Random generator creates 0 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:21.311 INF] Get weather forecast, the first day: {"Date": "2023-09-09T15:00:21.3108869+08:00", "TemperatureC": 23, "TemperatureF": 73, "Summary": "Scorching", "$type": "WeatherForecast"} [SimpleLog.Controllers.WeatherForecastController::Get():60]
[15:00:21.942 DBG] Random generator creates 4 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:21.948 INF] Get weather forecast, the first day: {"Date": "2023-09-09T15:00:21.9485481+08:00", "TemperatureC": 32, "TemperatureF": 89, "Summary": "Bracing", "$type": "WeatherForecast"} [SimpleLog.Controllers.WeatherForecastController::Get():60]
[15:00:22.527 DBG] Random generator creates 3 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:22.534 INF] Get weather forecast, the first day: {"Date": "2023-09-09T15:00:22.5340088+08:00", "TemperatureC": -2, "TemperatureF": 29, "Summary": "Balmy", "$type": "WeatherForecast"} [SimpleLog.Controllers.WeatherForecastController::Get():60]
[15:00:23.127 DBG] Random generator creates 0 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:23.133 INF] Get weather forecast, the first day: {"Date": "2023-09-09T15:00:23.1333763+08:00", "TemperatureC": -19, "TemperatureF": -2, "Summary": "Cool", "$type": "WeatherForecast"} [SimpleLog.Controllers.WeatherForecastController::Get():60]
[15:00:23.712 DBG] Random generator creates 0 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:23.716 INF] Get weather forecast, the first day: {"Date": "2023-09-09T15:00:23.7161048+08:00", "TemperatureC": 2, "TemperatureF": 35, "Summary": "Mild", "$type": "WeatherForecast"} [SimpleLog.Controllers.WeatherForecastController::Get():60]
[15:00:24.364 DBG] Random generator creates 2 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:24.368 FTL] Fatal weather warning [SimpleLog.Controllers.WeatherForecastController::Get():48]
System.ArgumentException: Fatal weather
   at SimpleLog.Controllers.WeatherForecastController.Get() in C:\Users\Phil\Desktop\dotnet\SimpleLog\SimpleLog\Controllers\WeatherForecastController.cs:line 48
[15:00:24.378 ERR] An unhandled exception has occurred while executing the request. [Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware::():]
System.ArgumentException: Fatal weather
   at SimpleLog.Controllers.WeatherForecastController.Get() in C:\Users\Phil\Desktop\dotnet\SimpleLog\SimpleLog\Controllers\WeatherForecastController.cs:line 48
   at lambda_method(Closure , Object , Object[] )
   at Microsoft.Extensions.Internal.ObjectMethodExecutor.Execute(Object target, Object[] parameters)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.SyncObjectResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)   
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeActionMethodAsync()
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeNextActionFilterAsync()
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeInnerFilterAsync()
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|19_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware.Invoke(HttpContext context)
[15:00:26.420 DBG] Random generator creates 3 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:26.424 INF] Get weather forecast, the first day: {"Date": "2023-09-09T15:00:26.4242421+08:00", "TemperatureC": 32, "TemperatureF": 89, "Summary": "Hot", "$type": "WeatherForecast"} [SimpleLog.Controllers.WeatherForecastController::Get():60]
[15:00:27.454 DBG] Random generator creates 4 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:27.459 INF] Get weather forecast, the first day: {"Date": "2023-09-09T15:00:27.4590077+08:00", "TemperatureC": 19, "TemperatureF": 66, "Summary": "Warm", "$type": "WeatherForecast"} [SimpleLog.Controllers.WeatherForecastController::Get():60]
[15:00:28.474 DBG] Random generator creates 8 [SimpleLog.Controllers.WeatherForecastController::Get():34]
[15:00:28.479 WRN] Error should not exceed 5, current value: 8 [SimpleLog.Controllers.WeatherForecastController::Get():38]
[15:00:28.484 INF] Get weather forecast, the first day: {"Date": "2023-09-09T15:00:28.4839676+08:00", "TemperatureC": 34, "TemperatureF": 93, "Summary": "Cool", "$type": "WeatherForecast"} [SimpleLog.Controllers.WeatherForecastController::Get():60]
```
