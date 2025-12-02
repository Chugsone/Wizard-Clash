using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        
        cardList.Add(new Card("Water", "Beats Fire"));
        cardList.Add(new Card("Fire", "Beats Earth"));
        cardList.Add(new Card("Earth", "Beats Water"));
    }
}
