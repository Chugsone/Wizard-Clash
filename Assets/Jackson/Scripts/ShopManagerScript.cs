using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[5, 5];

    void Start()
    {
        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Prices
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;

        //Quantities
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
    }


    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (CoinsManager.coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            CoinsManager.coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            CoinsManager.UpdateCoins();

            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;

            ButtonRef.GetComponent<ButtonInfo>().QuantutyTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }

    }
}
