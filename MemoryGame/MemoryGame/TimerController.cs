using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
  public class TimerController
  {

    TimerView _Tview;
    TimerModel _Tmodel;

    public TimerController()
    {

      _Tview = new TimerView(this);
      _Tmodel = new TimerModel();

    }

    public TimerView TimerGetView()
    {

      return _Tview;

    }

    public TimerModel getTModel()
    {

       return _Tmodel;

    }

    }
}
