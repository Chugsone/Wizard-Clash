using System.Collections;
using System.Collections.Generic;
using CardGame;
using NUnit.Framework;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<Card> allCards = new List<Card>();

    private int currentIndex = 0;

    public int maxHandSize = 5;

    public int currentHandSize;

    private HandManager handManager;

    void Start()
    {
        //load all cards from resources folder
        Card[] cards = Resources.LoadAll<Card>("Cards");

        // add the loaded cards to the allCards list
        allCards.AddRange(cards);

        handManager = FindFirstObjectByType<HandManager>();
        for (int i = 0; i < 5; i++)
        {
            DrawCard(handManager);
        }
    }

    void Update()
    {
        if (handManager != null)
        {
            currentHandSize = handManager.cardsInHand.Count;
        }
    }

    // Keep this method for programmatic calls that already pass a HandManager
    public void DrawCard(HandManager handManager)
    {
        if (handManager == null)
        {
            Debug.LogWarning("HandManager is null. Cannot draw card.");
            return;
        }

        // Prevent drawing when the hand is full
        if (handManager.cardsInHand.Count >= maxHandSize)
        {
            Debug.Log("Hand is full. Cannot draw more cards.");
            return;
        }

        if (allCards.Count == 0)
        {
            Debug.LogWarning("No cards left in the deck to draw.");
            return;
        }

        Card nextCard = allCards[currentIndex];
        handManager.AddCardToHand(nextCard);
        currentIndex = (currentIndex + 1) % allCards.Count;

        Debug.Log("player drew card: " + nextCard.cardName);
    }

    // Parameterless method suitable to bind to a UI Button's OnClick
    [ContextMenu("Draw One Card")]
    public void DrawOneCard()
    {
        if (handManager == null)
        {
            handManager = FindFirstObjectByType<HandManager>();
            if (handManager == null)
            {
                Debug.LogWarning("No HandManager found in scene. Cannot draw card.");
                return;
            }
        }

        DrawCard(handManager);
    }
}
