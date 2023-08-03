using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Calculator : MonoBehaviour
{
    
    [SerializeField] private InputField firstNumber;
    [SerializeField] private InputField twoNumber;
    [SerializeField] private Text total;


   public void Addition()
   {
    int firstNum, twoNum, totalNum;

    firstNum = Convert.ToInt32(firstNumber.text);
    twoNum = Convert.ToInt32(twoNumber.text);
    totalNum = firstNum + twoNum;

    total.text = totalNum.ToString();
   }

    public void Subtraction()
   {
    int firstNum, twoNum, totalNum;

    firstNum = Convert.ToInt32(firstNumber.text);
    twoNum = Convert.ToInt32(twoNumber.text);
    totalNum = firstNum - twoNum;

    total.text = totalNum.ToString();
   }

     public void Multiplication()
   {
    int firstNum, twoNum, totalNum;

    firstNum = Convert.ToInt32(firstNumber.text);
    twoNum = Convert.ToInt32(twoNumber.text);
    totalNum = firstNum * twoNum;

    total.text = totalNum.ToString();
   }

     public void Division()
   {
    int firstNum, twoNum, totalNum;

    firstNum = Convert.ToInt32(firstNumber.text);
    twoNum = Convert.ToInt32(twoNumber.text);
    totalNum = firstNum / twoNum;

    total.text = totalNum.ToString();
   }
}
