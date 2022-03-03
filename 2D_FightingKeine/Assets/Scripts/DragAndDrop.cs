using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 dragOffset;

    private void OnMouseDown()
    {
        dragOffset = transform.position - GetMousePosition();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePosition() + dragOffset;
        Debug.Log("I have been drag!");
    }

    Vector3 GetMousePosition()
    {
        //Return Vextor3 value where mouse is
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        return mousePosition;
    }
}