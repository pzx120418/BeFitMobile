using BeFitMobile.Models;
using Microsoft.Maui.Controls;
using System;

namespace BeFitMobile.Views;

public partial class ExerciseTypesPage : ContentPage
{
    public ExerciseTypesPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        exerciseList.ItemsSource = await App.Database.GetExerciseTypesAsync();
    }

    async void OnAddClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ExerciseTypeEditPage());

        exerciseList.ItemsSource = await App.Database.GetExerciseTypesAsync();
    }

    async void OnDeleteClicked(object sender, EventArgs e)
    {
        try
        {
            var button = sender as Button;

            if (button?.CommandParameter is ExerciseType exercise)
            {
                await App.Database.DeleteExerciseTypeAsync(exercise);

                exerciseList.ItemsSource = await App.Database.GetExerciseTypesAsync();
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("B³¹d", ex.Message, "OK");
        }
    }
}
