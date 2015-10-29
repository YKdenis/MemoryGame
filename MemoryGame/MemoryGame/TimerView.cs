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
  public partial class TimerView : UserControl
  {
    TimerController _controller;

    public TimerView(TimerController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    private void TimerView_Load(object sender, EventArgs e)
    {
       startTimer();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      _controller.getTModel().Tijd = Convert.ToInt32(timerTime.Text);
      _controller.getTModel().Tijd--;
      timerTime.Text = _controller.getTModel().Tijd.ToString();

      if(_controller.getTModel().Tijd == 0)
      {
          timerTime.Text = "Game  Over";
          timer1.Stop();
        _controller._memoryView.disableGame();  
          }

     }


    public void updateTimerLabel()
    {
        timerTime.Text = _controller.getTModel().Tijd.ToString();
    }


    public void startTimer()
    {
        timer1.Start();
    }

    public void stopTimer()
    {
      timer1.Stop();
    }

  }
}
