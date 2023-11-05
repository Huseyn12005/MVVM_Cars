using LessonMVVM.Commands;
using LessonMVVM.Models;
using LessonMVVM.Services;
using LessonMVVM.ViewModels.WindowViewModels;
using LessonMVVM.Views.Windows;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LessonMVVM.ViewModels.PageViewModels;

public class DashboardPageViewModel : NotificationService
{
    public ObservableCollection<Car> Cars { get; set; }


    public ICommand? AddViewCommand { get; set; }

    public DashboardPageViewModel()
    {
        Cars = new()
        {
            new("Audi", "Q8", new DateTime(2022, 10, 11)),
            new("Audi", "Q7", new DateTime(2022, 10, 11)),
            new("Hyudai", "Accent", new DateTime(2022, 10, 11)),
            new("Hyudai", "Elantra", new DateTime(2022, 10, 11)),
            new("Kia", "K5", new DateTime(2022, 10, 11)),
        };

        AddViewCommand = new RelayCommand(AddCarView);
    }

    public void AddCarView(object? parameter)
    {
        var addView = new AddCarView();
        addView.DataContext = new AddCarViewModel(Cars);
        addView.ShowDialog();
    }

    
}
