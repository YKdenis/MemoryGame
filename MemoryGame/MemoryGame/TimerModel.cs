using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
  public class TimerModel
  {

        int _tijd = 0;
        bool _gameOver = false;

        public int Tijd
        {

            get { return _tijd; }

            set { _tijd = value; }

        }


        public bool gameOver
        {
            get { return _gameOver; }
            set { _gameOver = value; }
        }

    }
}
