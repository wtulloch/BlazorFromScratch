﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Client
{
   public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services => { });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
