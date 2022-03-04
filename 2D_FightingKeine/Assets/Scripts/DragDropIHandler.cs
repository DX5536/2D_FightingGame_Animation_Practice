using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropIHandler : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private string itemMessage;

    [SerializeField]
    private int textBoxAnswerNumber;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    public string ItemMessage
    {
        get { return itemMessage; }
        set { itemMessage = value; }
    }

    public int TextBoxAnswerNumber
    {
        get { return textBoxAnswerNumber; }
        set { textBoxAnswerNumber = value; }
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.5f;
        canvasGroup.blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Event only called if mouse is click upon the object
    }

}