using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardGame;
using System;


public class HandManager : MonoBehaviour
{
    public DeckManager deckManager;

    public GameObject cardPrefab;

    public Transform handTransform;

    public float fanSpread = 7.5f;

    public float cardSpacing = 100f;

    public float verticalSpacing = 100f;

    public List<GameObject> cardsInHand = new List<GameObject>();

    void Start()
    {
        
    }

    public void AddCardToHand(Card cardData)
    {
        GameObject newCard = Instantiate(cardPrefab, handTransform.position, Quaternion.identity, handTransform);
        cardsInHand.Add(newCard);

        // set the card data of the instantiated card 
        newCard.GetComponent<CardDisplay>().cardData = cardData;

        UpdateHandVisuals();

    }
    void Update() 
    {
        UpdateHandVisuals();
    }

    private void UpdateHandVisuals()
    {
        int cardCount = cardsInHand.Count;

        if (cardCount == 1)
        {
            cardsInHand[0].transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            cardsInHand[0].transform.localPosition = new Vector3(0f, 0f, 0f);
            return;
        }



        for (int i = 0; i < cardCount; i++)
        {
            float rotationAngle = (fanSpread * (i - (cardCount - 1) / 2f));
            cardsInHand[i].transform.localRotation = Quaternion.Euler(0f, 0f, rotationAngle);

            float horizontalOffset = (cardSpacing * (i - (cardCount - 1) / 2f));

            float normalizePosition = (2f * i / (cardCount - 1) - 1f); //normalize card position between -1 and 1
            float verticalOffset = verticalSpacing * (1 - normalizePosition * normalizePosition); //cards in the center are higher

            cardsInHand[i].transform.localPosition = new Vector3(horizontalOffset, verticalOffset, 0f);
        }
    }
}
