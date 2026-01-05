using System;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    public int playerpoints;
    public int opponentpoints;
    public int winningPoints = 10;
    public TMPro.TMP_Text resultText; 
    public string WinText = "You Win!";
    public string loseText = "You Lose!";
    public Image playerbar;
    public Image opponentbar;

    void Update()
    {
        playerbar.fillAmount = (float)playerpoints / winningPoints;
        opponentbar.fillAmount = (float)opponentpoints / winningPoints;

        if (playerpoints >= winningPoints)
        {
            Debug.Log("You Win!");
            resultText.SetText(WinText);
        }
        if (opponentpoints >= winningPoints)
        {
            Debug.Log("You Lose!");
            resultText.SetText(loseText);
        }
    }
}
