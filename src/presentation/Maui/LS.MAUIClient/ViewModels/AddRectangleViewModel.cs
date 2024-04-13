using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LS.Application.Common.Interfaces.Services;
using LS.Domain.Entities;
using LS.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.MAUIClient.ViewModels
{
    public partial class AddRectangleViewModel: BaseViewModel
    {
        private readonly IRectangleService _rectangleService;
        [ObservableProperty]
        private Rectangle rectangle = new();
        public AddRectangleViewModel()
        {

        }
        public AddRectangleViewModel(IRectangleService rectangleService)
        {
            _rectangleService = rectangleService;
        }
        [RelayCommand]
        public void AddRectangle()
        { 
            _rectangleService.Add(new Rectangle()
            {
                Height = rectangle.Height,
                Width = rectangle.Width,
                Name = rectangle.Name
            }); 
        }
      
    }
}
