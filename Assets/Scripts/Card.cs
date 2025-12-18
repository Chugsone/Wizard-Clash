using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGame
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]

    public class Card : ScriptableObject 
    {
        public string cardName;

        public List<CardType> cardType;

        public Sprite cardSprite;

        public enum CardType
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
    }

}
 