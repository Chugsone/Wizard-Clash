using UnityEngine;

public class CardSlot : MonoBehaviour
{
    private void OnMouseEnter()
    {
        DragDrop.currentDraggedItem.parentAfterDrag = this.transform;
    }

    private void OnMouseExit()
    {
        DragDrop.currentDraggedItem.parentAfterDrag = null;
    }
}
