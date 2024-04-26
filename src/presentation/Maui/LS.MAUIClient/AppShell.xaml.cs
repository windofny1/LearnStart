using LS.MAUIClient.Pages;
using LS.MAUIClient.Pages.Common;
using LS.MAUIClient.Pages.Rectangles;

namespace LS.MAUIClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes(); 
        }
        public void RegisterRoutes()
        {
            Routing.RegisterRoute(Routes.MainRoute, typeof(MainPage));
            Routing.RegisterRoute(Routes.AddRectanglePageRoute, typeof(AddRectanglePage));
            Routing.RegisterRoute(Routes.RectangleRoute, typeof(RectanglePage));
        }
    }
}
