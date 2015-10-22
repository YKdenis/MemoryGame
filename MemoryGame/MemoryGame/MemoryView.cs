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
  public partial class MemoryView : UserControl
  {
    MemoryController _mController;
    Image cover = Properties.Resources.cover3;


    public MemoryView(MemoryController mController)
    {
      _mController = mController;
      InitializeComponent();
    }

    private void MemoryView_Load(object sender, EventArgs e)
    {

      //Console.WriteLine(_mController.shuffleKaarten(_mController.getMModel().kaarten, _mController.getMModel().kaartenShuffled));
      Console.WriteLine(_mController.getMModel().kaarten);
      foreach (PictureBox picture in panel1.Controls)
      {
        
        picture.Image = cover;
        
      }
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

  }
}
