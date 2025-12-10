using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsDisplay : MonoBehaviour
{
    private Text text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       text = GetComponent<Text>();
       if (text == null)
       {
           Debug.LogError("CoinsDisplay: no Text component found on this GameObject.");
       }
    }

    // Update is called once per frame
    void Update()
    {
        if (text == null) return;

        string[] temp = text.text.Split('$');
        text.text = temp[0] + "$" + CoinsManager.coins;
    }
}
