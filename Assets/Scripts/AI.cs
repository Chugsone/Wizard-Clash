using UnityEngine;
using System.Collections.Generic;

public class AI : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public List<Card> container = new List<Card>();
    public static List<Card> staticEnemyDeck = new List<Card>();


    public GameObject DropZone;
    public GameObject HandZone;

    public int x;
    public int deckSize;

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3; 
    public GameObject cardInDeck4;

    public GameObject CardToHand;

    public GameObject[] Clones;

    public static bool draw;

    void Start()
    {
        StartCoroutine(StartGame());

        Hand = GameObject.Find("EnemyHandZone");
        Zone = GameObject.Find("EnemyDropZone");

        x=0;
        deckSize =40;
        draw = true; 

        for(int i = 0; i < deckSize; i++)
        {
            x = Random.Range(1,7);
            deck[i] = Manager.cardList[x];
        }

    }

    // Update is called once per frame
    void Update()
    {
        staticEnemyDeck = deck;

    }
}
