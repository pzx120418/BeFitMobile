using BeFitMobile.Data;
using System;
using System.IO;
using System.Globalization;

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
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BeFit_final.db3"));
            }
            return database;
        }
    }

    public App()
    {
        InitializeComponent();

        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pl-PL");
        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("pl-PL");

        MainPage = new AppShell();
    }
}
