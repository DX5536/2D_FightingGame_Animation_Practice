using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotIHandler : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private string currentMessage;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;


            currentMessage = eventData.pointerDrag.GetComponent<DragDropIHandler>().ItemMessage ;
            Debug.Log(currentMessage);
        }
    }

}