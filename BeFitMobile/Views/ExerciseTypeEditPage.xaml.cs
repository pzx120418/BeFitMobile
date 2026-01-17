using BeFitMobile.Models;
using Microsoft.Maui.Controls;
using System;

namespace BeFitMobile.Views;

public partial class ExerciseTypeEditPage : ContentPage
{
    public ExerciseTypeEditPage()
    {
        InitializeComponent();
    }

    async void OnSaveClicked(object sender, EventArgs e)
    {
        var exercise = new ExerciseType
        {
            Name = nameEntry.Text
        };

        await App.Database.SaveExerciseTypeAsync(exercise);

        await Navigation.PopAsync();
    }
}
