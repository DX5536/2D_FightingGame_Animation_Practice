using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;


public class PlayerMovement : MonoBehaviour
{
    [Header("Moving Player to Mouse")]
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private MouseClickPosition mouseManager;

    [SerializeField]
    private float tweenDuration;
    [SerializeField]
    private bool isTweenSnapOn;

    void Start()
    {
        
    }

    void Update()
    {
        player.transform.DOMoveX(mouseManager.MousePositionValue.x , tweenDuration , isTweenSnapOn);
    }
}