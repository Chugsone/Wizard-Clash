using System;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    public int points;
    public int winningPoints = 10;
    public TMPro.TMP_Text winText; 
    public string WinText = "You Win!";
    public Image bar;

    void Update()
    {
        bar.fillAmount = points / winningPoints;

        if(points >= winningPoints)
        {
            Debug.Log("You Win!");
            winText.SetText(WinText);
        }
    }
}
