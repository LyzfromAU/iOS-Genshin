using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using yxts.Data;

namespace yxts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            playerBoard = new PlayerBoard
            {
                pos1 = "",
                pos2 = "",
                pos3 = "",
                pos4 = "",
                pos5 = "",
                pos6 = "",
                pos7 = "",
                pos8 = "",
                pos9 = "",
                pos10 = "",
                pos11 = "",
                pos12 = "",
                pos13 = "",
                pos14 = "",
                pos15 = "",
                pos16 = "",
                pos17 = "",
                pos18 = "",

            };
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
        public static PlayerBoard playerBoard { get; set; }
    }
}
