﻿using Microsoft.AspNetCore.Modules;
using Microsoft.Extensions.DependencyInjection;
using Orchard.MetaWeblog;

namespace Orchard.Title.RemotePublishing
{

    [Feature("Orchard.RemotePublishing")]
    public class RemotePublishingStartup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMetaWeblogDriver, TitleMetaWeblogDriver>();
        }
    }
}
