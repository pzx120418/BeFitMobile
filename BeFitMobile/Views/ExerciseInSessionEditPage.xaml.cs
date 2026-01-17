using BeFitMobile.Models;
using Microsoft.Maui.Controls;
using System;

namespace BeFitMobile.Views;

public partial class ExerciseInSessionEditPage : ContentPage
{
    public ExerciseInSessionEditPage()
    {
        InitializeComponent();
        LoadData();
    }

    async void LoadData()
    {
        exercisePicker.ItemsSource = await App.Database.GetExerciseTypesAsync();
        sessionPicker.ItemsSource = await App.Database.GetTrainingSessionsAsync();
    }

    async void OnSaveClicked(object sender, EventArgs e)
    {
        var selectedExercise = exercisePicker.SelectedItem as ExerciseType;
        var selectedSession = sessionPicker.SelectedItem as TrainingSession;

        if (selectedExercise == null || selectedSession == null)
        {
            await DisplayAlert("B³¹d", "Wybierz typ æwiczenia i sesjê", "OK");
            return;
        }

        var item = new ExerciseInSession
        {
            ExerciseTypeId = selectedExercise.Id,
            TrainingSessionId = selectedSession.Id,
            Weight = double.Parse(weightEntry.Text),
            Sets = int.Parse(setsEntry.Text),
            Repetitions = int.Parse(repsEntry.Text)
        };

        await App.Database.SaveExerciseInSessionAsync(item);

        await Navigation.PopAsync();
    }
}
