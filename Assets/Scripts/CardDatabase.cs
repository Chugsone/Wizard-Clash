using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        //cardList.Add(new Card(0, "Flood", 0, 0, "Beats Fire", Resources.Load<Sprite>("1")));
    }
}
