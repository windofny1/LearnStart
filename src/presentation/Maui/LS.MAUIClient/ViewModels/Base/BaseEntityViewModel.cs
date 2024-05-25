using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.MAUIClient.ViewModels.Base
{
    public partial class BaseEntityViewModel: ObservableObject
    {
        [ObservableProperty]
        public Guid id;
        [ObservableProperty]
        public int x;
        [ObservableProperty]
        public int y;
        [ObservableProperty]
        public string name;
    }
}
