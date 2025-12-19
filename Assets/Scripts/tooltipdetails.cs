using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Collections;
public class tooltipdetails : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string TitleText;
    public string DetailText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltips.Instance.Show(TitleText, DetailText);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        tooltips.Instance.Hide(TitleText, DetailText);
    }
}

