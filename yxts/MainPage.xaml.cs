using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace yxts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (App.playerBoard != null)
            {
                testLabel.Text = App.playerBoard.pos1;
            }
        }
        private void ToCar(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new BattlePage());
            ListOfChess.Children.Clear();
            foreach (var chess in Data.Chessess.GetChesses())
            {
                var btn = new Button()
                {
                    Text = chess.Name,
                    StyleId = chess.Id.ToString()
                };
                btn.Clicked += OnDynamicBtnClicked;
                ListOfChess.Children.Add(btn);
            }
        }
        private void OnDynamicBtnClicked(object sender, EventArgs e)
        {
            var myBtn = sender as Button;
            var myId = myBtn.StyleId;
            switch (myId)
            {
                case "1": 
                    break;
                default:
                    break;
            }
        }
    }
}
