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
    

    

    public MemoryWindow()
    {
      InitializeComponent();
    }

    private void MemoryWindow_Load(object sender, EventArgs e)
    {

      MemoryController memoryGame = new MemoryController();

      MemoryView memoryView = memoryGame.getMView();
            
      TimerController timer = memoryGame.getMView()._tController;

      TimerView timerView = timer.TimerGetView();

      int xPosTimer = memoryView.Width;

      timerView.Location = new Point(xPosTimer, 10);

      ScoreController scoreController = memoryGame.getMView()._sController;

      ScoreView scoreView = scoreController.getSView();

      int xPosScore = memoryView.Width;

      int yPosScore = timerView.Height;

      scoreView.Location = new Point(xPosScore, yPosScore);

      Controls.Add(memoryView);

      Controls.Add(timerView);

      Controls.Add(scoreView);

      

    }
  }
}
