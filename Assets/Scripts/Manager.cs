using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text Result;
    public Image AiChoice;

    public string[] Choices;
    public Sprite Water, Fire, Earth;

    public void PlayGame(string PlayerChoice)
    {
        string randomChoice = Choices[randomChoice.Range(0, Choices.Length)];

        switch(randomChoice)
        {
            case "Water";
             Result.Text = "Tie!";
            break;

            case "Fire":
            Result.Text = "You Win!";
             break;

            case "Earth":
            Result.Text = "You Lose!";
            break;

        }
        break;

        case "Fire";
                    switch(randomChoice)
            {
                case "Water";
                    Result.Text = "You Lose!";
                    break;
                case "Fire";
                Result.Text = "Tie!";
                 break;
                case "Earth";
                Result.Text = "You Win!";
                break;
            }
           
            case "Earth";
                    switch(randomChoice)
            {
                case "Water":
                    Result.Text = "You Win!";
                    break;
                case "Fire";
                Result.Text = "You Lose!";
                 break;
                case "Earth";
                Result.Text = "Tie!";
                break;
            }

        }

}
