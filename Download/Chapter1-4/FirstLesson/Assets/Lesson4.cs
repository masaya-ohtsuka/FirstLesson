using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Lesson4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Person[] parr = {
			new Person ("太郎", "山田"), 
			new Person ("花子", "田中") 
		};
		Debug.Log (parr [0].getFullName ("★"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}