using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
  public class ScoreModel
  {
    int _score = 0;
    int _highscore = 0;

    public int score {

        get { return _score; }

        set { value = _score; }

      }
    
    public int highscore
    {

      get { return _highscore; }

      set { value = _highscore;  }

    }
  }
}
