using BeFitMobile.Models;
using Microsoft.Maui.Controls;
using System;

namespace BeFitMobile.Views;

public partial class TrainingSessionsPage : ContentPage
{
    public TrainingSessionsPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        sessionList.ItemsSource = await App.Database.GetTrainingSessionsAsync();
    }

    async void OnAddClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TrainingSessionEditPage());

        sessionList.ItemsSource = await App.Database.GetTrainingSessionsAsync();
    }

    async void OnDeleteClicked(object sender, EventArgs e)
    {
        try
        {
            var button = sender as Button;

            if (button?.CommandParameter is TrainingSession session)
            {
                await App.Database.DeleteTrainingSessionAsync(session);

                sessionList.ItemsSource = await App.Database.GetTrainingSessionsAsync();
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("B³¹d", ex.Message, "OK");
        }
    }
}
