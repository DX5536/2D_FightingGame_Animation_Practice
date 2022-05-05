using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;


public class MouseClickPosition : MonoBehaviour
{
    [Header("Player's Starting Position in Editor")]
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private Vector3 mousePositionValue;

    //[SerializeField]
    private GameObject gameObject2;

    //Property to access saved mouse position_Read Only
    public Vector3 MousePositionValue
    {
        get { return mousePositionValue; }
    }


    private void OnMouseDown()
    {
        //mousePosition = Input.mousePosition;
    }
    void Start()
    {
        mousePositionValue = player.transform.position;
    }

    void Update()
    {
        //Save MousePosition upon L.Click
        if (Input.GetMouseButtonDown(0))
        {
            //This alone means Mouse in all the screen position -> NOT WorldPos
                //mousePositionValue = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
                //mousePosition = Input.mousePosition;

            //This will convert MousePos to WorldPoint of the game
                //mousePositionValue = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePositionValue = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x , Camera.main.ScreenToWorldPoint(Input.mousePosition).y , 0);
            
        }
    }
}