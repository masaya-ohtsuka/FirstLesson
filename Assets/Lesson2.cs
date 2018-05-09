using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int a = 7;
        if (a < 5)
            {
            Debug.Log("aは5より小さい");
            }
        else
            {
            Debug.Log("a は5 以上");
            }
        Debug.Log("終了");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
