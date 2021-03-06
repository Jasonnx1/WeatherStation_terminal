﻿using System.Threading;
using System.Windows;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// TODO 11 : COMPLETED Ajouter les ressources linguistiques au projet
        /// TODO 12 : COMPLETED Charger la langue d'affichage

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ApplicationView app = new ApplicationView();

            app.Show();

        }

        App()
        {
            var lang = WeatherApp.Properties.Settings.Default.Lang;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
        }
    }
}
