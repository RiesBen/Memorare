using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

using Memorare.visual;
using System;

namespace Memorare.Logic
{

    public class Game

    {
       private int cardRevelationCounter;
       private Options options;
       private Gameboard gameBoard;
       private Grid root;

        public Game(Options setOptions, Grid root)
        {
            this.root = root;
            cardRevelationCounter = 0;
            options = setOptions;
            gameBoard = new Gameboard(options);
        }

        public void runGame()
        {
            int cardNumber = options.getCardNumber();
            gameBoard.setBlankCards(cardNumber);
            shuffleCards(cardNumber);
            gameBoard.setView(root);

        }

        private void shuffleCards(int cardNumber)
        {
            Random numGen = new Random();
            int rowSize = (int)Math.Round(Math.Sqrt(cardNumber));
            Card[,] CardArray = new Card[rowSize, rowSize];
            Rectangle[,] CardBacks = gameBoard.getCardBacks();

            for(int i = 0; i<cardNumber; i++)
            {
                Card tmp = new Card(i, numGen.Next(), CardBacks[i / rowSize, i % rowSize]);

                CardArray[i / rowSize, i % rowSize] = tmp;
            }
        }
    }
}
