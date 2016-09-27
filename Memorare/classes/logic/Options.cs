using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorare.Logic
{
    public class Options
{
    private int cardNumber;
    private string cardTheme;

    public Options(int setCardNumber, String setCardTheme="default")
    {
        cardNumber = setCardNumber;
        cardTheme = setCardTheme;
    }



    //setter&getter
    public void setCardNumber(int amount)
    {
        cardNumber = amount;
    }

    public int getCardNumber()
    {
        return cardNumber;
    }
    public String getCardTheme()
    {
        return cardTheme;
    }
    }
}
