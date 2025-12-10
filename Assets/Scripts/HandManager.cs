using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardGame;
using System;


public class HandManager : MonoBehaviour
{
    public GameObject cardPrefab;

    public Transform handTransform;

    public float fanSpread = 5f;

    public List<GameObject> cardsInHand = new List<GameObject>();

    void Start()
    {
        AddCardToHand();
        AddCardToHand();
        AddCardToHand();
        AddCardToHand();
    }

    public void AddCardToHand()
    {
        GameObject newCard = Instantiate(cardPrefab, handTransform.position, Quaternion.identity, handTransform);
        cardsInHand.Add(newCard);

        UpdateHandVisuals();

    }

    private void UpdateHandVisuals()
    {
        int cardCount = cardsInHand.Count;
        for (int i = 0; i < cardCount; i++)
        {
            float rotationAngle = (fanSpread * (i - (cardCount - 1) / 2f));
            cardsInHand[i].transform.localRotation = Quaternion.Euler(0f, 0f, rotationAngle);
        }
    }
}
