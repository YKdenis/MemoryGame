using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
  public partial class ScoreView : UserControl
  {
        ScoreController _sController;


    public ScoreView(ScoreController sController)
    {
        _sController = sController;
        InitializeComponent();
    }

    private void ScoreView_Load(object sender, EventArgs e)
    {

    }

        private void label1_Click(object sender, EventArgs e)
    {

    }

    private void timerLabel_Click(object sender, EventArgs e)
    {

    }

    public void updateScoreLabel()
    {
        tellerScore.Text = _sController.getSModel().Score.ToString();
    }

    public void updateHighScoreLabel()
    {
        tellerHighscore.Text = _sController.getSModel().HighScore.ToString();
    }

    public void showGewonnen()
    {
      gewonnen.Visible = true;
    }

    public void hideGewonnen()
    {
      gewonnen.Visible = false;
    }

  }
}
