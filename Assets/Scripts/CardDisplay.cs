using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CardGame;

public class CardDisplay : MonoBehaviour
{

    public Card cardData;

    public Image cardImage;

    public TMP_Text nameText;
    public TMP_Text descriptionText;

    public Image[] typeImages;

    
    void Start()
    {
      UpdateCardDisplay();
    }

    public void UpdateCardDisplay()
    {
      nameText.text = cardData.cardName;
    }
    


}
