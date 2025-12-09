using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public enum Choice
    {
        Fire,
        Water,
        Earth,
        Vinus, 
        Tornado,
        Wind,
        Storm
    }

    public Text resultText;
    public Image AIChoice;

    public Choice[] Choices;
    public Sprite Fire, Water, Earth,Vinus,Tornado,Wind,Storm;

    public void PlayString(string choice)
    {
        //if (System.Enum.TryParse<Choice>(choice, out Choice choice2))
            //Play(choice2, choice: Choice);
    }

    public void Play(Choice myChoice, Choice choice)
    {
        Choice randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice)
        {
            case Choice.Earth:
                switch (myChoice)
                {
                    case Choice.Earth:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Vinus:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Tornado:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Wind:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Fire:
                        resultText.text = "You Win!";
                        break;

                    case Choice.Water:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Storm:
                        resultText.text = "You Lose!";
                        break;
                }
                AIChoice.sprite = Earth;
                break;

            case Choice.Water:
                switch (myChoice)
                {
                    case Choice.Fire:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Vinus:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Earth:
                        resultText.text = "You Win!";
                        break;

                    case Choice.Water:
                        resultText.text = "Draw!";
                        break;

                        case Choice.Storm:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Tornado:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Wind:
                        resultText.text = "Draw!";
                        break;
                }
                AIChoice.sprite = Water;
                break;

            case Choice.Fire:
                switch (myChoice)
                {
                    case Choice.Water:
                        resultText.text = "You Win!";
                        break;

                    case Choice.Storm:
                        resultText.text = "You Win!";
                        break;

                    case Choice.Wind:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Tornado:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Fire:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Earth:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Vinus:
                        resultText.text = "You Lose!";
                        break;
                }
                AIChoice.sprite = Fire;
                break;

            case Choice.Wind:
                switch (myChoice)
                {
                    case Choice.Earth:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Vinus:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Wind:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Fire:
                        resultText.text = "You Win!";
                        break;

                    case Choice.Tornado:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Water:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Storm:
                        resultText.text = "You Lose!";
                        break;
                }
                AIChoice.sprite = Wind;
                break;

            case Choice.Storm:
                switch (myChoice)
                {
                    case Choice.Storm:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Tornado:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Fire:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Wind:
                        resultText.text = "You Win!";
                        break;

                    case Choice.Water:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Vinus:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Earth:
                        resultText.text = "You Lose!";
                        break;
                }
                AIChoice.sprite = Storm;
                break;

            case Choice.Tornado:
                switch (myChoice)
                {
                    case Choice.Storm:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Tornado:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Fire:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Wind:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Water:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Vinus:
                        resultText.text = "You Win!";
                        break;

                    case Choice.Earth:
                        resultText.text = "Draw!";
                        break;
                }
                AIChoice.sprite = Tornado;
                break;

            case Choice.Vinus:
                switch (myChoice)
                {
                    case Choice.Storm:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Tornado:
                        resultText.text = "You Win!";
                        break;

                    case Choice.Fire:
                        resultText.text = "You Win!";
                        break;

                    case Choice.Wind:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Water:
                        resultText.text = "You Lose!";
                        break;

                    case Choice.Vinus:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Earth:
                        resultText.text = "Draw!";
                        break;
                }
                AIChoice.sprite = Vinus;
                break;
        }
    }
}
