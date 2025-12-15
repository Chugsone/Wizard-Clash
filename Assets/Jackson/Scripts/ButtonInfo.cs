using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{

    public int ItemID;
    public TMP_Text PriceTxt;
    public TMP_Text QuantutyTxt;
    public GameObject ShopManager;

    // Update is called once per frame
    void Update()
    {
        PriceTxt.text = "Price $" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        QuantutyTxt.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();
    }
}
