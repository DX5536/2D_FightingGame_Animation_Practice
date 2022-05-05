using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;


public class PlayerMovement : MonoBehaviour
{
    [Header("Player's Value")]
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Vector2 playerCurrentPos;
    [SerializeField]
    private SpriteRenderer playerSpriteRenderer;

    [Header("Mouse and Cursor's Value")]
    [SerializeField]
    private MouseClickPosition mouseManager;
    [SerializeField]
    private Vector2 lastMouseClickPos;

    [Header("DOTween's Value")]
    [SerializeField]
    private float tweenDuration;
    //[SerializeField]
    private bool isTweenSnapOn;

    void Start()
    {
        playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //Quick DOTween movement -> very rigid but works
        player.transform.DOMoveX(mouseManager.MousePositionValue.x , tweenDuration , isTweenSnapOn);

        lastMouseClickPos = mouseManager.MousePositionValue;
        playerCurrentPos = player.transform.position;

        //Now check: if Mouse click Right -> Mouse's x-Value bigger than playerCurrentPos
        if(playerCurrentPos.x < lastMouseClickPos.x)
        {
            playerSpriteRenderer.flipX = false;
            Debug.Log("Player moving Right");
        }

        //Mouse click Left -> Mouse's x-Value smaller than playerCurrentPos
        else
        {
            playerSpriteRenderer.flipX = true;
            Debug.Log("Player moving Left");
        }

        //In Space movement!!! (Like a real Ninja)
        /*if (mouseManager.IsPlayerMoving && (Vector2)transform.position != lastClickPos)
        {
            //Check if we are in the lastClickPos. If FALSE, move to it.
            float step = playerSpeed * Time.deltaTime;
            playerRigidBody.transform.position = Vector2.MoveTowards(player.transform.position, lastClickPos, step);
        }

        else
        {
            //If reach lastClickPos -> Can't move until mouseClick again
            mouseManager.IsPlayerMoving = false;
        }*/
    }
}