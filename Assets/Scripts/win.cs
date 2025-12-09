using System;
using UnityEngine;

public class win : MonoBehaviour
{
    public int points;
    public int winningPoints = 10;
    public TMPro.TMP_Text winText; 
    public string WinText = "You Win!";

    void Update()
    {
        if(points >= winningPoints)
        {
            Debug.Log("You Win!");
            winText.SetText(WinText);
        }
    }
}
