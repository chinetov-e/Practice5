using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Unity.VisualScripting;
using UnityEngine.Rendering;
using Unity.VisualScripting.FullSerializer;
using System.Globalization;

public class Practice : MonoBehaviour
{
    private int[] arr = {81, 22, 13, 54, 10, 34, 15, 26, 71, 68};
    private int[] arr2 = {81, 22, 13, 34, 10, 34, 15, 26, 71, 68};
    private void Start()
    {
        Debug.Log("Task 1:");
        SumOfEvenNumbersInRange(7, 21);
        Debug.Log("Task 2:");
        SumOfEvenNumbersInArray(arr);
        Debug.Log("Task 3:");
        Debug.Log($"Task number 3 part 1. Index of 34: {FirstOccurence(arr2, 34)}");
        Debug.Log($"Task number 3 part 2. Index of 55: {FirstOccurence(arr2, 55)}");
        Debug.Log("Task 4:");
        Debug.Log("Array before the sorting:");
        WriteArray(arr);
        SelectionSort(arr);
        Debug.Log("Array after sorting:");
        WriteArray(arr);
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

     private int FirstOccurence(int[] array, int digit)
     {
        int a = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == digit)
            {
                a = i;
                break;
            }
        }

        return a;
     }

     private void SelectionSort(int[] array)
     {
        int temp;
        int min;
        for (int i = 0; i < array.Length; i++)
{
    min = i;
    for(int j = i + 1; j < array.Length; j++)
    {
        if(array[min] > array[j])
        {
            temp = array[min];
            array[min] = array[j];
            array[j] = temp;
        }
    }
}
     }

     private void WriteArray(int[] array)
     {
        foreach(var a in array)
        {
            Debug.Log(a);
        }
     }
}
