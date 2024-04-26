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

namespace LS.MAUIClient.ViewModels.Rectangles
{
    public partial class AddRectangleViewModel: BaseViewModel
    {
     
        [ObservableProperty]
        private LS.Domain.Entities.Rectangle rectangle = new();
        private readonly IRectangleService _rectangleService;
        public AddRectangleViewModel()
        {

        }
        public AddRectangleViewModel(IRectangleService rectangleService)
        {
            _rectangleService = rectangleService;
        }
        [RelayCommand]
        public async Task AddRectangle()
        { 
            _rectangleService.Add(new LS.Domain.Entities.Rectangle()
            {
                Id=Guid.NewGuid(),
                Height = rectangle.Height,
                Width = rectangle.Width,
                Name = rectangle.Name
            });
            await Shell.Current.GoToAsync(".."); 
        }
       
      
    }
}
