using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MemoryGame
{
  public class MemoryController
  {

    MemoryView _mView;
    MemoryModel _mModel;

    public MemoryController()
    {

      _mView = new MemoryView(this);
      _mModel = new MemoryModel();

    }
    
    public MemoryView getMView()
    {
      return _mView;
    }

    public MemoryModel getMModel()
    {
      return _mModel;
    }

    public List<string> shuffleKaarten(List<string> listKaarten, List<string> shuffledListKaarten)
    {
      int lengthList = listKaarten.Count;

      for (int i = 0; i < lengthList; i++)
      {
        //int randomKaart = new Random().Next(0, listKaarten.Count);
        int randomKaart = new Random(Guid.NewGuid().GetHashCode()).Next(0, listKaarten.Count);
        //Console.WriteLine(randomKaart);
        //Console.WriteLine(listKaarten.Count);

        //Console.WriteLine(listKaarten[randomKaart]);
        shuffledListKaarten.Add(listKaarten[randomKaart]);
        //Console.WriteLine(shuffledListKaarten[i]);
        listKaarten.RemoveAt(randomKaart);

        //Console.WriteLine(Shuffled[i]);
        //Shuffled[i] = arrayKaarten[randomKaart];

        // On the end of the code, "myArray" has only lenght of 2 (so index at 2 was removed).
        //arrayKaarten = arrayKaarten.Where(w => w != arrayKaarten[randomKaart]).ToArray();

      }
      
      return shuffledListKaarten;


    }

    public void populateCardsList (List<string> kaarten)
        {
            kaarten.Add("card1-smaller");
            kaarten.Add("card1-smaller");
            kaarten.Add("card2-smaller");
            kaarten.Add("card2-smaller");
            kaarten.Add("card3-smaller");
            kaarten.Add("card3-smaller");
            kaarten.Add("card4-smaller");
            kaarten.Add("card4-smaller");
            kaarten.Add("card5-smaller");
            kaarten.Add("card5-smaller");
            kaarten.Add("card6-smaller");
            kaarten.Add("card6-smaller");
            kaarten.Add("card7-smaller");
            kaarten.Add("card7-smaller");
            kaarten.Add("card8-smaller");
            kaarten.Add("card8-smaller");
            kaarten.Add("card9-smaller");
            kaarten.Add("card9-smaller");
            kaarten.Add("card10-smaller");
            kaarten.Add("card10-smaller");


            _mModel.kaarten = kaarten;

            //return kaarten;
        }

        public List<string> createNewGame()
        {
            populateCardsList(_mModel.kaarten);
            Console.WriteLine("kaart 1 = " + _mModel.kaarten[1]);
            List<string> shuffled =  shuffleKaarten(_mModel.kaarten, _mModel.kaartenShuffled);
            Console.WriteLine("shuffled1 = " + shuffled[1] + "shuffled2 = " + shuffled[2]);
            return shuffled;
            //_mView._sController.getSModel().Score = 0;
        }
    }
}
