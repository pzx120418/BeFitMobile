using BeFitMobile.Data;
using System;
using System.IO;

namespace BeFitMobile;

public partial class App : Application
{
    static AppDatabase database;

    public static AppDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new AppDatabase(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BeFit.db3"));
            }
            return database;
        }
    }

    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}
