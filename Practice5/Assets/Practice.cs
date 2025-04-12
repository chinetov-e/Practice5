using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Unity.VisualScripting;
using UnityEngine.Rendering;

public class Practice : MonoBehaviour
{
    private int[] arr = {81, 22, 13, 54, 10, 34, 15, 26, 71, 68};
    private void Start()
    {
        SumOfEvenNumbersInRange(7, 21);
        SumOfEvenNumbersInArray(arr);
    }

    private void SumOfEvenNumbersInRange (int min, int max)
    {
        int sum = 0;
        while (min <= max)
        {
            if(min % 2 == 0)
            {
                sum += min;
            }
            min++;
        }
        Debug.Log($"The sum of the even numbers in range is {sum}");
    }

    private void SumOfEvenNumbersInArray(int[] array)
    {
        int sum = 0;
        foreach (var a in array)
        {
            if (a % 2 == 0)
            {
                sum += a;
            }
        }

        Debug.Log($"The sum of even numbers in array is {sum}");
    }
}
