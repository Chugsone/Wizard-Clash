using System.Collections;
using System.Collections.Generic;
using CardGame;
using NUnit.Framework;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<Card> allCards = new List<Card>();


    private int currentIndex = 0;

    void Start()
    {
        //load all cards from resources folder
        Card[] cards = Resources.LoadAll<Card>("Cards");

        // add the loaded cards to the allCards list
        allCards.AddRange(cards);
    }

    public void DrawCard(HandManager handManager)
    {
        if (allCards.Count == 0)
        {
            Debug.LogWarning("No cards left in the deck to draw.");
            return;

            Card nextCard = allCards[currentIndex];
            handManager.AddCardToHand(nextCard);
            currentIndex = (currentIndex + 1) % allCards.Count;
        }
    }
}
