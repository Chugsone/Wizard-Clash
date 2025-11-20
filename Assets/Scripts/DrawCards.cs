using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Player;

    // maximum number of cards allowed in hand
    public int maxHandSize = 3;

    public void OnClick()
    {
        if (Player == null)
        {
            Debug.LogWarning("Player (hand parent) is not assigned.");
            return;
        }

       
        int currentHandCount = Player.transform.childCount;
        if (currentHandCount >= maxHandSize)
        {
            Debug.Log("Hand is full. Cannot draw more cards.");
            return;
        }

  
        GameObject card = Instantiate(Card1, Vector2.zero, Quaternion.identity);
        card.transform.SetParent(Player.transform, false);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
