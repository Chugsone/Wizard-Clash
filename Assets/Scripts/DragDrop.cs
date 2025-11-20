using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static DragDrop currentDraggedItem;

    public Transform parentAfterDrag;
    private Vector2 originalPosition;
  

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        originalPosition = this.transform.position;
        parentAfterDrag = this.transform.parent;
        this.transform.SetParent(this.transform.root);
        transform.SetAsLastSibling();

        currentDraggedItem = this;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        transform.position = originalPosition;
        this.transform.SetParent(parentAfterDrag);
        currentDraggedItem = null;
    }
}