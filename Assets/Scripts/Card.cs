using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public string cardName;
    public string description;

    
    public Card()
    {
        cardName = "Default Card";
        description = "This is a default card description.";
    }

    public Card(string name, string desc)
    {
        cardName = name;
        description = desc;
    }
}