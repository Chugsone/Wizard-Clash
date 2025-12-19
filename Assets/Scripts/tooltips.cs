using UnityEngine;
using UnityEngine.LightTransport;

public class tooltips : MonoBehaviour
{
    public Canvas ParentCanvas;
    public Transform ToolTipTransform;
    public static tooltips Instance;

    void Start()
    {
        Instance = this;
    }
    void Update()
    {
        Vector2 movePos;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(ParentCanvas.transform as RectTransform, Input.mousePosition, ParentCanvas.worldCamera, out movePos);

        if (ToolTipTransform != null && ParentCanvas != null)
        {
            ToolTipTransform.position = ParentCanvas.transform.TransformPoint(movePos);
        }
        else
        {
            Debug.LogWarning("ToolTipTransform or ParentCanvas is not assigned.");
        }
    }
    public void Show(string TitleText,string DetailText)
    {
        ToolTipTransform.gameObject.SetActive(true);
    }
    public void Hide(string titleText, string DetailText)
    {
        ToolTipTransform.gameObject.SetActive(false);
    }
}
