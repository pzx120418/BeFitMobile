using BeFitMobile.Models;
using Microsoft.Maui.Controls;
using System;

namespace BeFitMobile.Views;

public partial class ExerciseInSessionEditPage : ContentPage
{
    public ExerciseInSessionEditPage()
    {
        InitializeComponent();
    }

    async void OnSaveClicked(object sender, EventArgs e)
    {
        var item = new ExerciseInSession
        {
            ExerciseTypeId = int.Parse(exerciseTypeEntry.Text),
            TrainingSessionId = int.Parse(sessionEntry.Text),
            Weight = double.Parse(weightEntry.Text),
            Sets = int.Parse(setsEntry.Text),
            Repetitions = int.Parse(repsEntry.Text)
        };

        await App.Database.SaveExerciseInSessionAsync(item);

        await Navigation.PopAsync();
    }
}
