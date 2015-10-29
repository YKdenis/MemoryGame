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
    public int tijd = 0;

    public TimerView(TimerController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    private void TimerView_Load(object sender, EventArgs e)
    {
      timer1.Start();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      //dan moet je hier eigenlijk ook de tijd gaan ophalen uit het model
      /*
      tijd = Convert.ToInt32(timerTime.Text);
      tijd--;
      timerTime.Text = tijd.ToString();
      
      if(tijd == 0)
      {
          Console.WriteLine("Game Over");
      }
      */

      _controller.getTModel().Tijd = Convert.ToInt32(timerTime.Text);
      _controller.getTModel().Tijd--;
      timerTime.Text = _controller.getTModel().Tijd.ToString();

      if(_controller.getTModel().Tijd == 0)
      {
          Console.WriteLine("Game Over");
          timer1.Stop();
      }

     }


    public void updateTimerLabel()
    {
        timerTime.Text = _controller.getTModel().Tijd.ToString();
    }

  }
}
