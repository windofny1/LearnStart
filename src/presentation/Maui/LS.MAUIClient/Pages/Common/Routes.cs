using LS.MAUIClient.Pages.Rectangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.MAUIClient.Pages.Common
{
    public static class Routes
    {
        public static string MainRoute { get; } = nameof(MainPage);
        public static string AddRectanglePageRoute { get; } = nameof(AddRectanglePage);
        public static string RectangleRoute { get; } = nameof(RectanglePage);
    }
}
