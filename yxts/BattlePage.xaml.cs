using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using yxts.Controller;
using yxts.Data;

namespace yxts
{
    public partial class BattlePage : ContentPage
    {
        public BattlePage()
        {
            InitializeComponent();
        }
        private void ReturnToHomePage(object sender, EventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new MainPage());
            BoardController.ChangeBoard(App.playerBoard);
            var myBtn = sender as Button;
            myBtn.Text = App.playerBoard.pos1;
            App.Current.MainPage = new NavigationPage(new MainPage());

        }
        private void BuyPos1(object sender, EventArgs e)
        {

        }

        private void ToPull(object sender, EventArgs e)
        {
            List<ChessProperties> p5List = Data.Chessess.GetChesses().Where(x => x.Price == 5).ToList();
            List<ChessProperties> p4List = Data.Chessess.GetChesses().Where(x => x.Price == 4).ToList();
            List<ChessProperties> p3List = Data.Chessess.GetChesses().Where(x => x.Price == 3).ToList();
            List<ChessProperties> p2List = Data.Chessess.GetChesses().Where(x => x.Price == 2).ToList();
            for (var i = 0; i < 6; i++)
            {
                double rnd = new Random().NextDouble();
                if (rnd < 0.15)
                {
                    var index = new Random().Next(p5List.Count());
                    switch(i)
                    {
                        case 0:
                            Card1Name.Text = p5List[index].Name;
                            Card1Ele.Text = p5List[index].Element;
                            Card1Price.Text = "$" + p5List[index].Price.ToString();
                            break;
                        case 1:
                            Card2Name.Text = p5List[index].Name;
                            Card2Ele.Text = p5List[index].Element;
                            Card2Price.Text = "$" + p5List[index].Price.ToString();
                            break;
                        case 2:
                            Card3Name.Text = p5List[index].Name;
                            Card3Ele.Text = p5List[index].Element;
                            Card3Price.Text = "$" + p5List[index].Price.ToString();
                            break;
                        case 3:
                            Card4Name.Text = p5List[index].Name;
                            Card4Ele.Text = p5List[index].Element;
                            Card4Price.Text = "$" + p5List[index].Price.ToString();
                            break;
                        case 4:
                            Card5Name.Text = p5List[index].Name;
                            Card5Ele.Text = p5List[index].Element;
                            Card5Price.Text = "$" + p5List[index].Price.ToString();
                            break;
                        case 5:
                            Card6Name.Text = p5List[index].Name;
                            Card6Ele.Text = p5List[index].Element;
                            Card6Price.Text = "$" + p5List[index].Price.ToString();
                            break;
                        default:
                            break;
                    }
                }
                else if (rnd < 0.35)
                {
                    var index = new Random().Next(p4List.Count());
                    switch (i)
                    {
                        case 0:
                            Card1Name.Text = p4List[index].Name;
                            Card1Ele.Text = p4List[index].Element;
                            Card1Price.Text = "$" + p4List[index].Price.ToString();
                            break;
                        case 1:
                            Card2Name.Text = p4List[index].Name;
                            Card2Ele.Text = p4List[index].Element;
                            Card2Price.Text = "$" + p4List[index].Price.ToString();
                            break;
                        case 2:
                            Card3Name.Text = p4List[index].Name;
                            Card3Ele.Text = p4List[index].Element;
                            Card3Price.Text = "$" + p4List[index].Price.ToString();
                            break;
                        case 3:
                            Card4Name.Text = p4List[index].Name;
                            Card4Ele.Text = p4List[index].Element;
                            Card4Price.Text = "$" + p4List[index].Price.ToString();
                            break;
                        case 4:
                            Card5Name.Text = p4List[index].Name;
                            Card5Ele.Text = p4List[index].Element;
                            Card5Price.Text = "$" + p4List[index].Price.ToString();
                            break;
                        case 5:
                            Card6Name.Text = p4List[index].Name;
                            Card6Ele.Text = p4List[index].Element;
                            Card6Price.Text = "$" + p4List[index].Price.ToString();
                            break;
                        default:
                            break;
                    }
                }
                else if (rnd < 0.65)
                {
                    var index = new Random().Next(p3List.Count());
                    switch (i)
                    {
                        case 0:
                            Card1Name.Text = p3List[index].Name;
                            Card1Ele.Text = p3List[index].Element;
                            Card1Price.Text = "$" + p3List[index].Price.ToString();
                            break;
                        case 1:
                            Card2Name.Text = p3List[index].Name;
                            Card2Ele.Text = p3List[index].Element;
                            Card2Price.Text = "$" + p3List[index].Price.ToString();
                            break;
                        case 2:
                            Card3Name.Text = p3List[index].Name;
                            Card3Ele.Text = p3List[index].Element;
                            Card3Price.Text = "$" + p3List[index].Price.ToString();
                            break;
                        case 3:
                            Card4Name.Text = p3List[index].Name;
                            Card4Ele.Text = p3List[index].Element;
                            Card4Price.Text = "$" + p3List[index].Price.ToString();
                            break;
                        case 4:
                            Card5Name.Text = p3List[index].Name;
                            Card5Ele.Text = p3List[index].Element;
                            Card5Price.Text = "$" + p3List[index].Price.ToString();
                            break;
                        case 5:
                            Card6Name.Text = p3List[index].Name;
                            Card6Ele.Text = p3List[index].Element;
                            Card6Price.Text = "$" + p3List[index].Price.ToString();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    var index = new Random().Next(p2List.Count());
                    switch (i)
                    {
                        case 0:
                            Card1Name.Text = p2List[index].Name;
                            Card1Ele.Text = p2List[index].Element;
                            Card1Price.Text = "$" + p2List[index].Price.ToString();
                            break;
                        case 1:
                            Card2Name.Text = p2List[index].Name;
                            Card2Ele.Text = p2List[index].Element;
                            Card2Price.Text = "$" + p2List[index].Price.ToString();
                            break;
                        case 2:
                            Card3Name.Text = p2List[index].Name;
                            Card3Ele.Text = p2List[index].Element;
                            Card3Price.Text = "$" + p2List[index].Price.ToString();
                            break;
                        case 3:
                            Card4Name.Text = p2List[index].Name;
                            Card4Ele.Text = p2List[index].Element;
                            Card4Price.Text = "$" + p2List[index].Price.ToString();
                            break;
                        case 4:
                            Card5Name.Text = p2List[index].Name;
                            Card5Ele.Text = p2List[index].Element;
                            Card5Price.Text = "$" + p2List[index].Price.ToString();
                            break;
                        case 5:
                            Card6Name.Text = p2List[index].Name;
                            Card6Ele.Text = p2List[index].Element;
                            Card6Price.Text = "$" + p2List[index].Price.ToString();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
