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
    }

    public void AddCardToHand()
    {
        GameObject newCard = Instantiate(cardPrefab, handTransform.position, Quaternion.identity, handTransform);
    }
}
