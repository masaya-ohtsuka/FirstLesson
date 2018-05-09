using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Person[] parr = new Person[5];
        parr [0] = new Person ();

        parr [0].firstname = "太郎";
        parr [0].lastname = "山田";
        Debug.Log(parr [0].GetFullName("★"));
    }
}