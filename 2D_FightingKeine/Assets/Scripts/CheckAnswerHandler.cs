using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswerHandler : MonoBehaviour
{
    public void ConfirmOrderOfEvents()
    {
        //Call the CheckAnswer
        CheckAnswerManager.CheckThreeAnswer();
    }
}