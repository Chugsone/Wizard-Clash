using system.collections;
using system.collections.generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour 
{
    public int Copper;
    public int Storm;
    public Text Copper_Text;
    public Text Storm_Text;

    void update() 
    {

    }

    public void BuyStorm() 
    { 
         if(Copper >= 5)
         {
            Copper -= 5;
            Copper_text.text = Copper.ToString();

            Storm += 1;
            Storm_Text.text = Storm.ToString();
        }
        else
        {
            print("Not enough Copper.");
        }
    }

}
