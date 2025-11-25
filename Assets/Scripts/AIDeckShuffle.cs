using System.Collections.Generic;
using UnityEngine;

public class AIDeckShuffle : MonoBehaviour
{

    public List<int> shuffleList = new List<int>();
    public int listRange = 52;
    public int shuffleTimes = 1;

    // internal state
    private bool isShuffled = false;

    private void Start()
    {
        
        ResetDeck();
    }

    public void ResetDeck()
    {
        shuffleList.Clear();
        for (int i = 0; i < listRange; i++)
            shuffleList.Add(i);

        isShuffled = false;
    }

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

    // Shuffle once
    public void ShuffleOnce()
    {
        if (isShuffled) return;
        ShuffleListRandomly();
        isShuffled = true;
        Debug.Log("AI deck shuffled once.");
    }

    // Draw the next card 
    public int DrawNextCard()
    {
        if (!isShuffled)
            ShuffleOnce();

        if (shuffleList.Count == 0)
            return -1;

        int lastIndex = shuffleList.Count - 1;
        int card = shuffleList[lastIndex];
        shuffleList.RemoveAt(lastIndex);
        return card;
    }

    // Remaining cards 
    public int RemainingCount => shuffleList.Count;

    public void CopyFrom(ShuffledDeck source)
    {
        if (source == null) return;
        shuffleList = new List<int>(source.shuffleList);
        listRange = source.listRange;
        shuffleTimes = source.shuffleTimes;
        isShuffled = source.shuffleList.Count != listRange;
    }

    public void SetListDirectly(List<int> list, bool markShuffled = true)
    {
        shuffleList = new List<int>(list ?? new List<int>());
        isShuffled = markShuffled;
    }
}

