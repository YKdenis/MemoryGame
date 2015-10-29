using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
  public class TimerController
  {
    public MemoryView _memoryView;
    TimerView _Tview;
    TimerModel _Tmodel;

    public TimerController(MemoryView memoryView)
    {

      _Tview = new TimerView(this);
      _Tmodel = new TimerModel();
      _memoryView = memoryView;

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
