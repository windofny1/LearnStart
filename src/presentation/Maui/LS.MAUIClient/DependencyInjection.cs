using LS.Infrastracture;
using LS.MAUIClient.ViewModels;
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
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterPages(this MauiAppBuilder mauiAppBuilder)
        {

            mauiAppBuilder.Services.AddSingleton<MainPage>();
         

            return mauiAppBuilder;
        }
    }
}
