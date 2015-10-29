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
    public ScoreController _sController = new ScoreController();
    public TimerController _tController;

    Image cover = Properties.Resources.cover3;

    List<PictureBox> pictureBoxes = new List<PictureBox>();
    

    //onderstaande variabelen dienen om de image van de omgedraaide kaarten in te bewaren
    

    //onderstaande variabelen dienen om te kijken op welke picturebox geklikt is, zodat je de image terug op cover kan zetten als de kaarten niet aan elkaar gelijk zijn
    
        


    public MemoryView(MemoryController mController)
    {
      _mController = mController;
      _tController = new TimerController(this);
      InitializeComponent();
    }

    private void MemoryView_Load(object sender, EventArgs e)
    {
      //_mController.populateCardsList(_mController.getMModel().kaarten);
      //shuffledKaarten = _mController.shuffleKaarten(_mController.getMModel().kaarten, _mController.getMModel().kaartenShuffled);

      //Console.WriteLine(_mController.shuffleKaarten(_mController.getMModel().kaarten, _mController.getMModel().kaartenShuffled));
      //Console.WriteLine(shuffledKaarten);
      //Console.WriteLine(_mController.getMModel().kaarten[0]);

      //alle pictureboxes van het panel in een list gaan steken zodat ze accessible zijn
      pictureBoxes.Add(pictureBox1);
      pictureBoxes.Add(pictureBox2);
      pictureBoxes.Add(pictureBox3);
      pictureBoxes.Add(pictureBox4);
      pictureBoxes.Add(pictureBox5);
      pictureBoxes.Add(pictureBox6);
      pictureBoxes.Add(pictureBox7);
      pictureBoxes.Add(pictureBox8);
      pictureBoxes.Add(pictureBox9);
      pictureBoxes.Add(pictureBox10);
      pictureBoxes.Add(pictureBox11);
      pictureBoxes.Add(pictureBox12);
      pictureBoxes.Add(pictureBox13);
      pictureBoxes.Add(pictureBox14);
      pictureBoxes.Add(pictureBox15);
      pictureBoxes.Add(pictureBox16);
      pictureBoxes.Add(pictureBox17);
      pictureBoxes.Add(pictureBox18);
      pictureBoxes.Add(pictureBox19);
      pictureBoxes.Add(pictureBox20);


      /*foreach (PictureBox picture in panel1.Controls) //moet for loop worden waar telkens voor elke picture de afbeelding overeenkomstig met i in de shuffled array list
{

  picture.Image = cover;

}

for(int i = 0; i < _mController.getMModel().kaartenShuffled.Count; i++)
      {
          //object o = Properties.Resources.ResourceManager.GetObject("card9")
          Console.WriteLine(shuffledKaarten[i]);
          //pictureBoxes[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(kaartenShuffled[i]);
          //pictureBoxes[i].Image = Properties.Resources.card1_smaller;
      }*/

      createNewGame();

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      //Console.WriteLine( ((PictureBox)sender).Name );
    }

    // algemene clickmethode //om deze te kunnen gebruiken, moet je in MemoryView.Designer.cs de foreach uit commentaar zetten
    private void handleCardClick(object sender, EventArgs e)
    {
        //Console.WriteLine(((PictureBox)sender).Name);

        //testje: de sender is diegene waar op geklikt is, daarvan kan je dus rechtstreeks de image aanpassen:
        //((PictureBox)sender).Image = Properties.Resources.card1_smaller;

        //je gaat de naam van de picturebox ophalen
        string nameOfPictureBox = ((PictureBox)sender).Name;

        //hierin zullen de laatste karakters van de naam als integer gestoken worden
        int lastCharInt = 0;


        //dan ga je kijken of de lengte van de naam 11 of 12 karakters is (pictureBox1 - pictureBox9 = 11 karakters     pictureBox10 - pictureBox20 = 12 karakters)
        if (nameOfPictureBox.Length == 11)
        {
            //je gaat het laatste karakter van de naam bepalen om te bepalen op welke picturebox je geklikt hebt en van welke picturebox je de background image dus moet aanpassen.
            string lastChar = nameOfPictureBox[nameOfPictureBox.Length - 1].ToString();
            //de string dan omzetten naar een integer, zodat je hem als index kan gebruiken
            lastCharInt = Int32.Parse(lastChar);
            //Console.WriteLine("laatste karakter = " + lastCharInt);
        }
        else if(nameOfPictureBox.Length == 12)
        {
            //als de picturebox eindigt op 10-20, moet je de 2 laatste karakters gaan opvragen
            string lastChars = nameOfPictureBox.Substring(nameOfPictureBox.Length - 2);
            lastCharInt = Int32.Parse(lastChars);
        }

        //dan ga je de achtergrondimage van de picturebox waar op geklikt is gelijk zetten aan zijn waarde van de kaartenShuffled
        ((PictureBox)sender).Image = (Image)Properties.Resources.ResourceManager.GetObject(_mController.getMModel().kaartenShuffled[(lastCharInt)-1]);


        if (_mController.getMModel().flippedCard1 == null && _mController.getMModel().flippedCard2 == null)
        {
        _mController.getMModel().flippedCard1 = _mController.getMModel().kaartenShuffled[(lastCharInt) - 1];
            _mController.getMModel().card1 = lastCharInt;
            //Console.WriteLine("card1 = " + card1);
        }
        else if(_mController.getMModel().flippedCard1 != null && _mController.getMModel().flippedCard2 == null)
        {
        _mController.getMModel().flippedCard2 = _mController.getMModel().kaartenShuffled[(lastCharInt) - 1];
            _mController.getMModel().card2 = lastCharInt;
            //Console.WriteLine("card2 = " + card2);
        }
        if(_mController.getMModel().flippedCard1 != null && _mController.getMModel().flippedCard2 != null)
        {
            //Console.WriteLine("flipped card1= " + flippedCard1 + "and flipped card2 = " + flippedCard2);
            //Console.WriteLine("card1 =" + card1 + "and card2 = " + card2);
            //als er 2 kaarten omgedraaid zijn, moet je gaan controleren of ze hetzelfde zijn
            if(_mController.getMModel().flippedCard1 == _mController.getMModel().flippedCard2)
            {
                Console.WriteLine("you added 10 points to your score");
                //je score in het model bijwerken
                _sController.getSModel().Score += 10;
                //je scoreLabel in de view bijwerken
                _sController.getSView().updateScoreLabel();
                //je highscore gaan bijwerken in het model (highscore wordt per sessie bijgehouden)
                _sController.calculateHighScore();
                _sController.getSView().updateHighScoreLabel();
                
                if(_sController.getSModel().Score == 100)
                {
                    //hierin misschien best een aparte methode oproepen, anders wordt de handleclick wel heel uitgebreid
                    Console.WriteLine("Yay, gewonnen");
                    //dat hieronder moet nog helemaal aangepast worden
                    int tijd = Convert.ToInt32(_tController.getTModel().Tijd);
                    _sController.getSModel().Score += tijd;
                    Console.WriteLine("totale score = " + _sController.getSModel().Score);
                    _sController.getSView().updateScoreLabel();
                    //je highscore gaan bijwerken in het model (highscore wordt per sessie bijgehouden)
                    _sController.calculateHighScore();
                    _sController.getSView().updateHighScoreLabel();
                    _tController.TimerGetView().stopTimer();

                    _sController.getSView().showGewonnen();
                    }
                
                //als de kaarten gelijk aan elkaar zijn wordt hun enabled op false gezet, zodat je er niet meer op kan klikken en je dus niet kan valsspelen om je score te verhogen
                pictureBoxes[_mController.getMModel().card1 - 1].Enabled = false;
                pictureBoxes[_mController.getMModel().card2 - 1].Enabled = false;
                }
            else
            {
                 Console.WriteLine("Kaarten zijn niet gelijk aan elkaar");
                 //System.Threading.Thread.Sleep(2300);
                 //pictureBoxes[card1-1].Image = cover;
                 //pictureBoxes[card2-1].Image = cover;
                 timer1.Start();
            }

        _mController.getMModel().flippedCard1 = null;
        _mController.getMModel().flippedCard2 = null;

      }

     }

     private void timer1_Tick(object sender, EventArgs e)
     {
         timer1.Stop();
         pictureBoxes[(_mController.getMModel().card1 - 1)].Image = cover;
         pictureBoxes[(_mController.getMModel().card2 - 1)].Image = cover;
     }


    private void createNewGame()
    {
        if(_mController.getMModel().kaartenShuffled != null)
        {
        //Console.WriteLine(kaartenShuffled.Count);
        _mController.getMModel().kaartenShuffled.Clear();
        }

      //nieuwe list met shuffled kaarten aanmaken
      _mController.getMModel().kaartenShuffled = _mController.createNewGame();

        foreach (PictureBox picture in panel1.Controls) //moet for loop worden waar telkens voor elke picture de afbeelding overeenkomstig met i in de shuffled array list
        {
            picture.Image = cover;
        }

            _tController.getTModel().Tijd = 40;
            _tController.TimerGetView().updateTimerLabel();
            _tController.TimerGetView().startTimer();
            _sController.getSView().hideGewonnen();
    }

    private void button_new_game_Click(object sender, EventArgs e)
    {
        _sController.getSModel().Score = 0;
        _sController.getSView().updateScoreLabel();

        foreach (PictureBox picture in panel1.Controls) //moet for loop worden waar telkens voor elke picture de afbeelding overeenkomstig met i in de shuffled array list
        {
            picture.Enabled = true;
        }

        createNewGame();
    }
      
    public void disableGame()
    {
     
      foreach( PictureBox picture in panel1.Controls)
      {
        picture.Enabled = false;
      }

    }
  }



}
