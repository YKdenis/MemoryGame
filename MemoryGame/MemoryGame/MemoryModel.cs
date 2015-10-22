using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
  public class MemoryModel
  {

    string[] _kaarten = { "card1-smaller", "card2-smaller", "card3-smaller", "card4-smaller", "card5-smaller", "card6-smaller", "card7-smaller", "card8-smaller", "card9-smaller", "card10-smaller", "card1-smaller", "card2-smaller", "card3-smaller", "card4-smaller", "card5-smaller", "card6-smaller", "card7-smaller", "card8-smaller", "card9-smaller", "card10-smaller" };
    string[] _kaartenShuffled;

    public string[] kaarten
    {

      get { return _kaarten; }
      set { _kaarten = value;  }

    }

    public string[] kaartenShuffled
    {

      get { return _kaartenShuffled;  }
      set { _kaartenShuffled = value;  }
    }


  }
}
