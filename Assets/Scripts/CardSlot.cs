using CardGame;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(HorizontalLayoutGroup))]
public class CardSlot : MonoBehaviour, IPointerEnterHandler
{
    public UnityEvent<Card.CardType> OnDrag;

    public int Limit = 1;
    public List<GameObject> cardsInSlot = new List<GameObject>();

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnMouseEnter");

        if (DragDrop.currentDraggedItem != null) { 
            DragDrop.currentDraggedItem.parentAfterDrag = this.transform;
            DragDrop.onDragEvent=OnDrag;
        } 

    }
}
