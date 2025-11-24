using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    
    public Text resultText;
    public Image AIChoice;

    public string[] Choices;
    public Sprite Fire, Water, Earth;

    public void Play(string myChoice)
    {
        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice)
        {
            case "Earth":
                switch (myChoice)
                {
                    case "Earth":
                        resultText.text = "Draw!";
                        break;

                    case "Fire":
                        resultText.text = "You Lose!";
                        break;

                    case "Water":
                        resultText.text = "You Win!";
                        break;
                }
                AIChoice.sprite = Earth;
                break;

            case "Water":
                switch (myChoice)
                {
                    case "Earth":
                        resultText.text = "You Lose!";
                        break;
                    case "Fire":
                        resultText.text = "You Win!";
                        break;
                    case "Water":
                        resultText.text = "Draw!";
                        break;
                }
                AIChoice.sprite = Water;
                break;

            case "Fire":
                switch (myChoice)
                {
                    case "Earth":
                        resultText.text = "You Win!";
                        break;
                    case "Fire":
                        resultText.text = "Draw!";
                        break;
                    case "Water":
                        resultText.text = "You Lose!";
                        break;
                }
                AIChoice.sprite = Fire;
                break;
        }
    }
}
