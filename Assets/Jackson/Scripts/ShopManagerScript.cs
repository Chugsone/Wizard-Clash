using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[13, 13];

    void Start()
    {
        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;
        shopItems[1, 8] = 8;    
        shopItems[1, 9] = 9;
        shopItems[1, 10] = 10;
        shopItems[1, 11] = 11;
        shopItems[1, 12] = 12;

        //Prices
        shopItems[2, 1] = 20;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 20;
        shopItems[2, 4] = 30;
        shopItems[2, 5] = 30;
        shopItems[2, 6] = 30;
        shopItems[2, 7] = 40;
        shopItems[2, 8] = 40;
        shopItems[2, 9] = 40;
        shopItems[2, 10] = 60;
        shopItems[2, 11] = 60;
        shopItems[2, 12] = 60;

        //Quantities
        shopItems[3, 1] = PlayerPrefs.GetInt("Card1", 0);
        shopItems[3, 2] = PlayerPrefs.GetInt("Card2", 0);
        shopItems[3, 3] = PlayerPrefs.GetInt("Card3", 0);
        shopItems[3, 4] = PlayerPrefs.GetInt("Card4", 0);
        shopItems[3, 5] = PlayerPrefs.GetInt("Card5", 0);
        shopItems[3, 6] = PlayerPrefs.GetInt("Card6", 0);
        shopItems[3, 7] = PlayerPrefs.GetInt("Card7", 0);
        shopItems[3, 8] = PlayerPrefs.GetInt("Card8", 0);
        shopItems[3, 9] = PlayerPrefs.GetInt("Card9", 0);
        shopItems[3, 10] = PlayerPrefs.GetInt("Card10", 0);
        shopItems[3, 11] = PlayerPrefs.GetInt("Card11", 0);
        shopItems[3, 12] = PlayerPrefs.GetInt("Card12", 0);
    }


    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (CoinsManager.coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            CoinsManager.coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            CoinsManager.UpdateCoins();

            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            UpdateShop();

            ButtonRef.GetComponent<ButtonInfo>().QuantutyTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }

    }

    public void UpdateShop()
    {
        PlayerPrefs.SetInt("Card1", shopItems[3, 1]);
        PlayerPrefs.SetInt("Card2", shopItems[3, 2]);
        PlayerPrefs.SetInt("Card3", shopItems[3, 3]);
        PlayerPrefs.SetInt("Card4", shopItems[3, 4]);
        PlayerPrefs.SetInt("Card5", shopItems[3, 5]);
        PlayerPrefs.SetInt("Card6", shopItems[3, 6]);
        PlayerPrefs.SetInt("Card7", shopItems[3, 7]);
        PlayerPrefs.SetInt("Card8", shopItems[3, 8]);
        PlayerPrefs.SetInt("Card9", shopItems[3, 9]);
        PlayerPrefs.SetInt("Card10", shopItems[3, 10]);
        PlayerPrefs.SetInt("Card11", shopItems[3, 11]);
        PlayerPrefs.SetInt("Card12", shopItems[3, 12]);

        PlayerPrefs.Save();
    }

}
