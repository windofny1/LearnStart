using CommunityToolkit.Mvvm.ComponentModel;
using LS.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.MAUIClient.ViewModels.Rectangles.EntityViewModels
{
    public partial class RectangleViewModel:BaseEntityViewModel
    {
        [ObservableProperty]
        public int width;
        [ObservableProperty]
        public int height;
    }
}
