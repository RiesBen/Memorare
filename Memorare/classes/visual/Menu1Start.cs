using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Memorare.Logic;

namespace Memorare.visual
{
    public class Menu1Start : VisualLayer
    {
        private TextBlock mainTitle;
        private StackPanel buttons;

        private Button startGame;
        private Button options;
        private Button cardThemes;
        
        public Menu1Start(Grid root)
        {
            baseLayer = new StackPanel();

            mainTitle = new TextBlock();
            mainTitle.Name = "MainTitle";
            mainTitle.Text = "Memorare";
            //            mainTitle.Margin.Top = "250"; //Margins:0,250,0,30
            //            mainTitle.Margin.Bottom = 30;
            mainTitle.HorizontalAlignment = HorizontalAlignment.Center;

            startGame = new Button();
            startGame.Name = "startGame";
            startGame.Content = "Start";

            MemorareClicker click = new MemorareClicker(root);
            startGame.Click += click.MainMStartGame_Click;

            options = new Button();
            options.Name = "options";
            options.Content = "Options";

            cardThemes = new Button();
            cardThemes.Name = "cardThemes";
            cardThemes.Content = "Card Themes";

            buttons = new StackPanel();
            buttons.Name = "MainButtons";
            buttons.HorizontalAlignment = HorizontalAlignment.Center;
            buttons.Children.Add(startGame);
            buttons.Children.Add(options);
            buttons.Children.Add(cardThemes);

            baseLayer.Children.Add(mainTitle);
            baseLayer.Children.Add(buttons);
        }
    }
  }