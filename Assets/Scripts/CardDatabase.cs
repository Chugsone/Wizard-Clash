using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "Flood", "Beats Fire", Resources.Load<Sprite>("1")));
        cardList.Add(new Card(1, "Fire", "Beats Wind", Resources.Load<Sprite>("2")));
        cardList.Add(new Card(2, "Wind", "Beats Earth", Resources.Load<Sprite>("3")));
        cardList.Add(new Card(3, "Earth", "Beats Lightning", Resources.Load<Sprite>("4")));
    }
}
