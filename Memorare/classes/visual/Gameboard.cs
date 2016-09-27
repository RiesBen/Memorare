using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Memorare.Logic;

namespace Memorare.visual
{
    public class Gameboard : VisualLayer
    {
        private TextBlock mainTitle;
        private Panel cardArea;
        private Options option;
        private Rectangle[,] cardBack;

        public Gameboard(Options opt)
        {
            this.option = opt;
            mainTitle = new TextBlock();
            mainTitle.Name = "GameTitle";
            mainTitle.Text = "StartGame!";

            cardArea = new StackPanel();

            baseLayer = new StackPanel();
            baseLayer.Children.Add(mainTitle);
            baseLayer.Children.Add(cardArea);
        }

        public void setBlankCards(int cardNumber)
        {
            int rowSize = (int) Math.Round(Math.Sqrt(cardNumber));
            cardBack = new Rectangle[rowSize, rowSize];


            //color of the CardBack
            SolidColorBrush cardBackground = new SolidColorBrush();
            cardBackground.Color = Windows.UI.Colors.Beige;

            // 
            Windows.UI.Xaml.Style cardStyle = new Style { TargetType = typeof(Rectangle) };
            cardStyle.Setters.Add(new Setter(Shape.FillProperty, cardBackground));
            cardStyle.Setters.Add(new Setter(Shape.WidthProperty, 200));
            cardStyle.Setters.Add(new Setter(Shape.HeightProperty, 140));
            cardStyle.Setters.Add(new Setter(Shape.MarginProperty, "20,20,20,20"));

            for (int i = 0; i < rowSize; i++)
            {
                StackPanel cardRow = new StackPanel();
                cardRow.Orientation = Orientation.Horizontal;
                cardRow.HorizontalAlignment = HorizontalAlignment.Center;
                for (int j = 0; j < rowSize; j++)
                {
                    Rectangle temp = new Rectangle();
                    temp.Style = cardStyle;
                    cardBack[i, j] = temp;
                    cardRow.Children.Add(cardBack[i, j]);
                }
                cardArea.Children.Add(cardRow);
            }
        }

        internal Rectangle[,] getCardBacks()
        {
            return cardBack;
        }

        public void setTextTitle(String newHeader)
        {
            mainTitle.Text = newHeader;
        }
    }
}