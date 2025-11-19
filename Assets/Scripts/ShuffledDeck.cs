using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShuffledDeck : MonoBehaviour
{
    public List<int> shuffleList = new List<int>();
    public int listRange = 52;
    public int shuffleTimes = 1;

    // Assign these in the Inspector
    public Button shuffleButton;
    public Button drawButton;
    [SerializeField] private Cards _cardsScript;

    // state
    private bool isShuffled = false;

    private void Start()
    {
        ResetDeck();

        if (shuffleButton != null)
            shuffleButton.onClick.AddListener(ShuffleOnce);

        if (drawButton != null)
            drawButton.onClick.AddListener(OnDrawButtonPressed);
    }

    private void OnDestroy()
    {
        if (shuffleButton != null)
            shuffleButton.onClick.RemoveListener(ShuffleOnce);

        if (drawButton != null)
        {
            drawButton.onClick.RemoveListener(OnDrawButtonPressed);
            
        }
    }

    // Rebuilds the deck to [0 .. listRange-1]
    public void ResetDeck()
    {
        shuffleList.Clear();
        for (int i = 0; i < listRange; i++)
            shuffleList.Add(i);

        isShuffled = false;
    }

    // Called by the UI Button (or you can call this from code)
    public void ShuffleListRandomly()
    {
        for (int t = 0; t < shuffleTimes; t++)
        {
            for (int i = shuffleList.Count - 1; i > 0; i--)
            {   
                int r = Random.Range(0, i + 1);
                int tmp = shuffleList[i];
                shuffleList[i] = shuffleList[r];
                shuffleList[r] = tmp;
            }
        }
    }

    // Shuffle exactly once 
    public void ShuffleOnce()
    {
        if (isShuffled) return;
        ShuffleListRandomly();
        isShuffled = true;
        Debug.Log("Deck shuffled once.");
    }

    // Draw the next card in the shuffled order 
    // Removes the card so it can't be drawn again. Returns -1 if empty.
    public int DrawNextCard()
    {
        if (!isShuffled)
            ShuffleOnce();

        if (shuffleList.Count == 0)
            return -1;

        int lastIndex = shuffleList.Count - 1;
        int card = shuffleList[lastIndex];
        _cardsScript.CardList.Add(card); // add card to player's hand
        shuffleList.RemoveAt(lastIndex); // remove so it can't be drawn again
        return card;
    }
    private void OnDrawButtonPressed()
    {
        int card = DrawNextCard();
        if (card == -1)
        {
            Debug.Log("Deck is empty.");
            return;
        }

        // hides card that was taken from deck
        Debug.Log($"Drew card id {card} (hidden to player). Cards remaining: {shuffleList.Count}");

       
    }
}


