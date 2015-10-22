using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
  public partial class MemoryWindow : Form
  {
    bool playAgain = false;

    

    public MemoryWindow()
    {
      InitializeComponent();
    }

    private void MemoryWindow_Load(object sender, EventArgs e)
    {

      MemoryController memoryGame = new MemoryController();

      MemoryView memoryView = memoryGame.getMView();

      TimerController timer = new TimerController();

      TimerView timerView = timer.TimerGetView();

      int xPosTimer = memoryView.Width;

      timerView.Location = new Point(xPosTimer, 10);

      Controls.Add(memoryView);

      Controls.Add(timerView);

      

    }
  }
}
