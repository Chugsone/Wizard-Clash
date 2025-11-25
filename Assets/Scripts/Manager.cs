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
        Earth
    }

    public Text resultText;
    public Image AIChoice;

    public Choice[] Choices;
    public Sprite Fire, Water, Earth;

    public void PlayString(string choice)
    {
        if (System.Enum.TryParse<Choice>(choice, out Choice choice2))
            Play(choice2);
    }

    public void Play(Choice myChoice)
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

                    case Choice.Fire:
                        resultText.text = "You Win!";
                        break;

                    case Choice.Water:
                        resultText.text = "You Lose!";
                        break;
                }
                AIChoice.sprite = Earth;
                break;

            case Choice.Water:
                switch (myChoice)
                {
                    case Choice.Earth:
                        resultText.text = "You Lose!";
                        break;
                    case Choice.Fire:
                        resultText.text = "You Win!";
                        break;
                    case Choice.Water:
                        resultText.text = "Draw!";
                        break;
                }
                AIChoice.sprite = Water;
                break;

            case Choice.Fire:
                switch (myChoice)
                {
                    case Choice.Earth:
                        resultText.text = "You Win!";
                        break;
                    case Choice.Fire:
                        resultText.text = "Draw!";
                        break;
                    case Choice.Water:
                        resultText.text = "You Lose!";
                        break;
                }
                AIChoice.sprite = Fire;
                break;
        }
    }
}
