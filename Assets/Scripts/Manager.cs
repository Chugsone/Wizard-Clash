using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public enum Choice
    {
        Fire,
        Tsunami,
        Vinus, 
        Tornado,
        Wind,
        Storm,
        Rain,
        Pheonix,
        IceShards,
        Vines,
        MudSlide,
        WindGust,
        Meteor
    }
   
    public TMPro.TMP_Text resultText;
    public Image AIChoice;

    public Choice[] Choices;
    public Sprite Fire, Tsunami, Vinus, Tornado, Wind, Storm, Rain, Pheonix, IceShards, Vines, MudSlide, WindGust, Meteor;

    public void PlayString(string choice)
    {
        if (System.Enum.TryParse(choice, out Choice choice2))
        {
            Play(choice2);
        }
    }

    public void Play(Choice myChoice)
    {
        Choice randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice)
        {
            case Choice.Vines:
                switch (myChoice)
                {
                    case Choice.Vines:
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
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Rain:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Storm:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }
                AIChoice.sprite = Vines;
                break;

            case Choice.Rain:
                switch (myChoice)
                {
                    case Choice.Fire:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Vinus:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Vines:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                    case Choice.Rain:
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

                    case Choice.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }
                AIChoice.sprite = Rain;
                break;

            case Choice.Fire:
                switch (myChoice)
                {
                    case Choice.Rain:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Storm:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Wind:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Tornado:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Fire:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Vines:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Vinus:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }
                AIChoice.sprite = Fire;
                break;

            case Choice.Wind:
                switch (myChoice)
                {
                    case Choice.Vines:
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
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Tornado:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Rain:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Storm:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
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
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Wind:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Rain:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Vinus:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Vines:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                }
                AIChoice.sprite = Storm;
                break;

            case Choice.Tornado:
                switch (myChoice)
                {
                    case Choice.Storm:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Tornado:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Fire:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Wind:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Rain:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Vinus:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Vines:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }
                AIChoice.sprite = Tornado;
                break;

            case Choice.Vinus:
                switch (myChoice)
                {
                    case Choice.Storm:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Tornado:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Fire:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Wind:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Rain:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.Vinus:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Vines:
                        resultText.text = "Draw!";
                        break;

                    case Choice.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Choice.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Choice.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }
                AIChoice.sprite = Vinus;
                break;

            case Choice.Meteor:
                switch (myChoice)
                {
                    case Choice.Rain:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }


        }
    }
}
