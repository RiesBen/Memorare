using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml.Shapes;

namespace Memorare.Logic
{
    public class Card
    {
        int id;
        int picture;
        Rectangle CardBack { get; set; }

        public Card(int id, int picture, Rectangle CardBack)
        {
            this.id = id;
            this.picture = picture;
            this.CardBack = CardBack;
            EventHandler(CardBack, );
        }


    }
}