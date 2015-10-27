using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
  public class ScoreController
  {
        ScoreView _sView;
        ScoreModel _sModel;


        public ScoreController()
        {

            _sView = new ScoreView(this);
            _sModel = new ScoreModel();

        }

        public ScoreView getSView()
        {
            return _sView;
        }

        public ScoreModel getSModel()
        {
            return _sModel;
        }

  }
}
