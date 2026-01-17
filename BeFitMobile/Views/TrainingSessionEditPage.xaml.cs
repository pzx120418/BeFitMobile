using BeFitMobile.Models;
using Microsoft.Maui.Controls;
using System;

namespace BeFitMobile.Views;

public partial class TrainingSessionEditPage : ContentPage
{
    public TrainingSessionEditPage()
    {
        InitializeComponent();
    }

    async void OnSaveClicked(object sender, EventArgs e)
    {
        var session = new TrainingSession
        {
            StartTime = startDatePicker.Date,
            EndTime = endDatePicker.Date
        };

        await App.Database.SaveTrainingSessionAsync(session);

        await Navigation.PopAsync();
    }
}
