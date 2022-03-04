using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CheckAnswerManager : MonoBehaviour
{
    private static CheckAnswerManager instance;

    private void Awake()
    {
        //Create an instance
        if (instance != null)
        {
            Destroy(this);
        }

        else if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    //Check 3 answers event
    public static event Action onCheckThreeAnswer;
    public static void CheckThreeAnswer()
    {
        if (onCheckThreeAnswer != null)
        {
            onCheckThreeAnswer();
        }
    }
}