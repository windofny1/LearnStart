﻿using LS.Infrastracture;
using LS.MAUIClient.Pages;
using LS.MAUIClient.Pages.Rectangles;
using LS.MAUIClient.ViewModels;
using LS.MAUIClient.ViewModels.Rectangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.MAUIClient
{
    public static class DependencyInjection
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddInfrastracture(); 
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<MainPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<AddRectangleViewModel>();
            mauiAppBuilder.Services.AddSingleton<RectanglePageViewModel>();
            
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterPages(this MauiAppBuilder mauiAppBuilder)
        {

            mauiAppBuilder.Services.AddSingleton<MainPage>();
            mauiAppBuilder.Services.AddSingleton<AddRectanglePage>();
            mauiAppBuilder.Services.AddSingleton<RectanglePage>();
            return mauiAppBuilder;
        }
    }
}
