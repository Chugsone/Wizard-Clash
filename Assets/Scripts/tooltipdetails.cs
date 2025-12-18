using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Collections;
public class tooltipdetails : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onPointerEnter(PointerEventData eventData)
    {
        tooltips.Instance.Show();
    }
    public void onPointerExit(PointerEventData eventData)
    {
        tooltips.Instance.Hide();
    }
}

