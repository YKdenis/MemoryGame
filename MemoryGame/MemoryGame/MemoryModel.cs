using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
  public class MemoryModel
  {
    //oorspronkelijke list met vaste volgorde
    List<string> _kaarten = new List<string>();
    //nieuwe list met willekeurige volgorde
    List<string> _kaartenShuffled = new List<string>();
    
    //hierin wordt de nummer van de pictureboxen bijgehouden van de omgedraaide kaarten
    int _card1 = 0;
    int _card2 = 0;
    
    //hiherin wordt de naam van de image van de omgedraaide kaarten bijgehouden
    string _flippedCard1;
    string _flippedCard2;

    public List<string> kaarten
    {

      get { return _kaarten; }
      set { _kaarten = value;  }

    }

    public List<string> kaartenShuffled
    {

      get { return _kaartenShuffled;  }
      set { _kaartenShuffled = value;  }
    }

    public int card1
    {
      get { return _card1; }
      set { _card1 = value; }
    }

    public int card2
    {
      get { return _card2; }
      set { _card2 = value; }
    }

    public string flippedCard1
    {
      get { return _flippedCard1; }
      set { _flippedCard1 = value; }
    }

    public string flippedCard2
    {
      get { return _flippedCard2; }
      set { _flippedCard2 = value; }
    }

  }
}
