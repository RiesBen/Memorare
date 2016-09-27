using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Memorare.Logic
{
    class MemorareClicker
    {
        private Grid root;

        public MemorareClicker(Grid root)
        {
            this.root = root;
        }

        public void MainMStartGame_Click(object sender, RoutedEventArgs e)
        {
            Options options = new Options(setCardNumber: 16);
            Game game = new Game(setOptions: options, root: this.root);
            game.runGame();
        }
        public void Card_click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
