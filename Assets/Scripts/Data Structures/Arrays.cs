using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    [SerializeField] private int[] listOfNumbers = {1,2,3,4,5,6,7,7,8,8 };

    [SerializeField] private GameObject[] listOfGameObjects = new GameObject[2];

    [SerializeField] private GameObject prefabObject;

    int[,] twoDimensionalArray = new int[2, 4] { 
        { 1, 2, 2, 3 }, 
        { 3, 4, 6, 8 } 
    };



    private void Start()
    {
        listOfGameObjects[0] = Instantiate(prefabObject);

        Debug.Log($"The first element in the array2D is {twoDimensionalArray[0, 0]} ") ;

        Debug.Log($"The Length of array {nameof(listOfNumbers)} is {listOfNumbers.Length}") ;

        Debug.Log($"The Length of array {nameof(twoDimensionalArray)} is {twoDimensionalArray.Length}") ;

        Debug.Log($"The Rank of array {nameof(twoDimensionalArray)} is {twoDimensionalArray.Rank}") ;

        Debug.Log($"The Length of first row array {nameof(twoDimensionalArray)} is {twoDimensionalArray.GetLength(0)}") ;

        Debug.Log($"The Length of second row array {nameof(twoDimensionalArray)} is {twoDimensionalArray.GetLength(1)}") ;


    }
}
