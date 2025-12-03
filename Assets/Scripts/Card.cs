using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardName;
    public string description;

    public Sprite thisImage;
    
    public Card()
    {
        cardName = "Default Card";
        description = "This is a default card description.";
    }

    public Card(int Id, string CardName, string Description)
    {
        id = Id;
        this.cardName = CardName;
        this.description = Description;

        thisImage = thisImage;
    }
}