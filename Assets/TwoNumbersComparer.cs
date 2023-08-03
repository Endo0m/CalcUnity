using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private InputField oneNumber;
    [SerializeField] private InputField twoNumber;
    [SerializeField] private Text total;

    public void onCheckClick()
    {

    int firstNum, twoNum, totalNum;

    firstNum = Convert.ToInt32(oneNumber.text);
    twoNum = Convert.ToInt32(twoNumber.text);
    
        if (firstNum == twoNum)
        {
            total.text = "Верны";
        }
        else 
        {
            total.text = "Не Верны";
        }
    }
}
