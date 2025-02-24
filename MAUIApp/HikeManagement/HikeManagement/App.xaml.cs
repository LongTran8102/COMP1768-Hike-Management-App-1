﻿using System;
using Xamarin.Forms;
using System.IO;
using HikeManagement.View;

namespace HikeManagement
{
    public partial class App : Application
    {
        private static SQLiteHelper db;
        public static SQLiteHelper MyDatabase
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "HikeManage.db3"));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HikePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
