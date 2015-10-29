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
        //nieuwe randomnummer genereren om de kaartnaam van een randompositie uit de originele list te halen
        int randomKaart = new Random(Guid.NewGuid().GetHashCode()).Next(0, listKaarten.Count);

        shuffledListKaarten.Add(listKaarten[randomKaart]);
        listKaarten.RemoveAt(randomKaart);

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
        }

        public List<string> createNewGame()
        {
            populateCardsList(_mModel.kaarten);
            List<string> shuffled =  shuffleKaarten(_mModel.kaarten, _mModel.kaartenShuffled);
            return shuffled;
        }
    }
}
