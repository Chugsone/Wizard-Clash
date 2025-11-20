using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(HorizontalLayoutGroup))]
public class CardSlot : MonoBehaviour, IPointerEnterHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnMouseEnter");

        if (DragDrop.currentDraggedItem != null)
            DragDrop.currentDraggedItem.parentAfterDrag = this.transform;
    }
}
