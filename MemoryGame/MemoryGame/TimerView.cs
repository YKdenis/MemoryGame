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
      timer1.Start();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      int tijd = Convert.ToInt32(timerTime.Text);
      tijd--;
      timerTime.Text = tijd.ToString();
    }

  }
}
