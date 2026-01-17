using BeFitMobile.Models;
using Microsoft.Maui.Controls;
using System;

namespace BeFitMobile.Views;

public partial class ExerciseInSessionPage : ContentPage
{
    public ExerciseInSessionPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        exerciseInSessionList.ItemsSource = await App.Database.GetExercisesInSessionAsync();
    }

    async void OnAddClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ExerciseInSessionEditPage());

        exerciseInSessionList.ItemsSource = await App.Database.GetExercisesInSessionAsync();
    }

    async void OnDeleteClicked(object sender, EventArgs e)
    {
        var button = sender as Button;

        if (button?.CommandParameter is ExerciseInSession item)
        {
            await App.Database.DeleteExerciseInSessionAsync(item);

            exerciseInSessionList.ItemsSource = await App.Database.GetExercisesInSessionAsync();
        }
    }
}
