﻿using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

namespace SuperAbp.MenuManagement.HttpApi.Client.ConsoleTestApp;

public class ConsoleTestAppHostedService : IHostedService
{
    private readonly IConfiguration _configuration;

    public ConsoleTestAppHostedService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using (var application = await AbpApplicationFactory.CreateAsync<MenuManagementConsoleApiClientModule>(options =>
        {
           options.Services.ReplaceConfiguration(_configuration);
           options.UseAutofac();
        }))
        {
            await application.InitializeAsync();
            

            await application.ShutdownAsync();
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
