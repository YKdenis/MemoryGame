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

    public int Score {

        get { return _score; }

        set { _score = value; }

      }
    
    public int HighScore
    {

      get { return _highscore; }

      set { _highscore = value;  }

    }
  }
}
