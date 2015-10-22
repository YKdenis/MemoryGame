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
    

    Random Location = new Random(); // Haalt een random waarde uit de posX en Ypos lijst --> coordinaten
    List<int> posX = new List<int>(); // Lijst met X posities van de kaarten
    List<int> posY = new List<int>(); // Lijst met Y posities van de kaarten

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

    public string[] shuffleKaarten(string[] arrayKaarten, string[] Shuffled)
    {
      int length = arrayKaarten.Length;

      for (int i = 0; i < length; i++)
      {
        
        int randomKaart = new Random().Next(0, arrayKaarten.Length);
        Console.WriteLine(arrayKaarten);
        Shuffled[i] = arrayKaarten[randomKaart];

        // On the end of the code, "myArray" has only lenght of 2 (so index at 2 was removed).
        arrayKaarten = arrayKaarten.Where(w => w != arrayKaarten[randomKaart]).ToArray();

      }

      return Shuffled;


    }
  }
}
