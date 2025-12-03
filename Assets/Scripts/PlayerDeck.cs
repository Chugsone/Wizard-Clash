using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();

    public int x;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = 0;

        for(int i=0;i<40;i++)
        {
            x = Random.Range(1, 3);
            deck[i]= CardDatabase.cardList[x];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
