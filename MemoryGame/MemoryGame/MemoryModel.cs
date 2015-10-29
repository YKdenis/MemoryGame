using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
  public class MemoryModel
  {

    //string[] _kaarten = { "card1-smaller", "card2-smaller", "card3-smaller", "card4-smaller", "card5-smaller", "card6-smaller", "card7-smaller", "card8-smaller", "card9-smaller", "card10-smaller", "card1-smaller", "card2-smaller", "card3-smaller", "card4-smaller", "card5-smaller", "card6-smaller", "card7-smaller", "card8-smaller", "card9-smaller", "card10-smaller" };
    //string[] _kaartenShuffled;
    List<string> _kaarten = new List<string>();
    //_kaarten.add
    List<string> _kaartenShuffled = new List<string>();

    

    int _card1 = 0;
    int _card2 = 0;

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
