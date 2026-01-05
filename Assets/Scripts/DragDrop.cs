using CardGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static DragDrop currentDraggedItem;
    public static UnityEvent<Card.CardType> onDragEvent;

    public Transform parentAfterDrag;
    private Vector2 originalPosition;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        originalPosition = this.transform.position;
        parentAfterDrag = this.transform.parent;
        this.transform.SetParent(this.transform.root);
        transform.SetAsLastSibling();
        GetComponentInChildren<Image>().raycastTarget = false;

        currentDraggedItem = this;

        FindFirstObjectByType<HandManager>().cardsInHand.Remove(this.gameObject);
        transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        
        transform.position = Input.mousePosition;

    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

        if (parentAfterDrag.TryGetComponent(out CardSlot slot))
        {
            if(slot.cardsInSlot.Count >= slot.Limit)
            {
                Destroy(slot.cardsInSlot[0]);
                slot.cardsInSlot.RemoveAt(0);
            }
            slot.cardsInSlot.Add(this.gameObject);
        }

        this.transform.SetParent(parentAfterDrag);
        currentDraggedItem = null; 
        GetComponentInChildren<Image>().raycastTarget = true;
        onDragEvent?.Invoke(GetComponent<CardDisplay>().cardData.cardType);
    }



}