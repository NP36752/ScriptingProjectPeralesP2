using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctionsScript : MonoBehaviour
{
    // make variable of type int and set to 5
    int myInt = 36;


    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    

    int MultiplyByTwo (int number)    
    {
        int result;
        result = number * 2;
        return result;
    }
}
