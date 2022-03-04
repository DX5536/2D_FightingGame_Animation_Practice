using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckAnswerBehaviour : MonoBehaviour
{
    [SerializeField]
    private SlotIHandler[] emptySlots;

    [SerializeField]
    private bool[] hasEmptySlotBeingFilled;

    [SerializeField]
    private GameObject[] endingGOs;

    private void OnEnable()
    {
        CheckAnswerManager.onCheckThreeAnswer += CompareAnswers;
    }

    private void OnDisable()
    {
        CheckAnswerManager.onCheckThreeAnswer -= CompareAnswers;
    }

    public void PrintCompareAnswerLog()
    {
        for (int i = 0; i <emptySlots.Length; i++)
        {
            for (var j = 0 ; j < hasEmptySlotBeingFilled.Length ; j++)
            {
                hasEmptySlotBeingFilled[j] = emptySlots[i].HasTextBox;
            }

            Debug.Log("TextBoxAnswerNumber " + emptySlots[i].CurrentTextBoxAnswerNumber +
                             " at SlotIndex " + emptySlots[i].SlotIndex + " with HasTextBox value " + emptySlots[i].HasTextBox);
        }

    }

    private void CompareAnswers()
    {
        //Deactivate all ending first
        foreach (var endings in endingGOs)
        {
            endings.SetActive(false);
        }

        for (int i = 0 ; i < emptySlots.Length ; i++)
        {
            //If the first emptySlot_0 is "It started to rain (2)" -> Ending_2
            if (emptySlots[0].CurrentTextBoxAnswerNumber == 2)
            {
                endingGOs[2].SetActive(true);
                Debug.Log("Reach Ending_2");
            }

            //If last emptySlot_2 is "It started to rain(2)" -> Ending_0 or 1
            else if (emptySlots[2].CurrentTextBoxAnswerNumber == 2)
            {
                if (emptySlots[0].CurrentTextBoxAnswerNumber == 0)
                {
                    endingGOs[0].SetActive(true);
                    Debug.Log("Reach Ending_0");
                }

                else if (emptySlots[0].CurrentTextBoxAnswerNumber == 1)
                {
                    endingGOs[1].SetActive(true);
                    Debug.Log("Reach Ending_1");
                }
            }

            else
            {
                endingGOs[3].SetActive(true);
                Debug.Log("Reach Ending_3 INVALID");
            }
        }
    }
}