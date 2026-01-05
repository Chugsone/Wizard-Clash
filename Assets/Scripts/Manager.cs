using CardGame;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public TMPro.TMP_Text resultText;
    public Image AIChoice;

    //private Vector2 _gizmosPosition = new Vector2()

    public Card.CardType[] Choices;
    public Sprite Fire, Tsunami, Vinus, Tornado, Wind, Storm, Rain, Pheonix, IceShards, Vines, MudSlide, WindGust, Meteor;

    public void PlayString(string choice)
    {
        if (System.Enum.TryParse(choice, out Card.CardType choice2))
        {
            Play(choice2);
        }
    }

    public void Play(Card.CardType myChoice)
    {
        Card.CardType randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice)
        {
            case Card.CardType.Vines:
                switch (myChoice)
                {
                    case Card.CardType.Vines:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Fire:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Rain:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Storm:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }
                AIChoice.sprite = Vines;
                break;

            case Card.CardType.Rain:
                switch (myChoice)
                {
                    case Card.CardType.Fire:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Vines:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                    case Card.CardType.Rain:
                        resultText.text = "Draw!";
                        break;

                        case Card.CardType.Storm:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }
                AIChoice.sprite = Rain;
                break;

            case Card.CardType.Fire:
                switch (myChoice)
                {
                    case Card.CardType.Rain:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Storm:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Fire:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Vines:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }
                AIChoice.sprite = Fire;
                break;

            case Card.CardType.Wind:
                switch (myChoice)
                {
                    case Card.CardType.Vines:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Fire:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Rain:
                        resultText.text = "Draw"; 
                        break;

                    case Card.CardType.Storm:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                }
                AIChoice.sprite = Wind;
                break;

            case Card.CardType.Tornado:
                switch (myChoice)
                {
                    case Card.CardType.Storm:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Fire:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Rain:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Vines:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }
                AIChoice.sprite = Tornado;
                break;

            case Card.CardType.Vinus:
                switch (myChoice)
                {
                    case Card.CardType.Storm:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Fire:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Rain:
                        resultText.text = "You Lose!"; 
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Vines:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }
                AIChoice.sprite = Vinus;
                break;

            case Card.CardType.Meteor:
                switch (myChoice)
                {
                    case Card.CardType.Fire:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Storm:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Rain:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Vines:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "Draw";
                        break;
                }
                AIChoice.sprite = Meteor;
                break;

            case Card.CardType.WindGust:
                switch (myChoice)
                {
                    case Card.CardType.Fire:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Storm:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Rain:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "Draw!";
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Vines:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;
                }
                AIChoice.sprite = WindGust;
                break;

            case Card.CardType.MudSlide:
                switch (myChoice)
                {
                    case Card.CardType.Fire:
                        resultText.text = "You lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Storm:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Rain:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Vines:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;
                }
                AIChoice.sprite = MudSlide;
                break;

            case Card.CardType.IceShards:
                switch (myChoice)
                {
                    case Card.CardType.Fire:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Storm:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Rain:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "You Lose!";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Vines:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;
                }
                AIChoice.sprite = IceShards;
                break;

            case Card.CardType.Pheonix:
                switch (myChoice)
                {
                    case Card.CardType.Fire:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Storm:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Rain:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Vines:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "Draw";
                        break;
                }
                AIChoice.sprite = Pheonix;
                break;

            case Card.CardType.Storm:
                switch (myChoice)
                {
                    case Card.CardType.Fire:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Storm:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Rain:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Vines:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "Draw";
                        break;
                }
                AIChoice.sprite = Storm;
                break;

            case Card.CardType.Tsunami:
                switch (myChoice)
                {
                    case Card.CardType.Fire:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Tsunami:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Vinus:
                        resultText.text = "You Win!";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Tornado:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.Wind:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Storm:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Rain:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.Pheonix:
                        resultText.text = "Draw";
                        break;

                    case Card.CardType.IceShards:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Vines:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.MudSlide:
                        resultText.text = "You Lose";
                        FindFirstObjectByType<win>().opponentpoints++;
                        break;

                    case Card.CardType.WindGust:
                        resultText.text = "You Win";
                        FindFirstObjectByType<win>().playerpoints++;
                        break;

                    case Card.CardType.Meteor:
                        resultText.text = "Draw";
                        break;
                }
                AIChoice.sprite = Tsunami;
                break;
        }
    }
  
}
