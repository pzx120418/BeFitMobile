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
        DateTime start = startDatePicker.Date + startTimePicker.Time;
        DateTime end = endDatePicker.Date + endTimePicker.Time;

        if (end <= start)
        {
            await DisplayAlert("B³¹d", "Data i godzina zakoñczenia musi byæ póŸniejsza ni¿ rozpoczêcia", "OK");
            return;
        }

        var session = new TrainingSession
        {
            StartTime = start,
            EndTime = end
        };

        await App.Database.SaveTrainingSessionAsync(session);

        await Navigation.PopAsync();
    }
}
