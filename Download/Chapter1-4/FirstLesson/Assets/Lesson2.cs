using UnityEngine;
using System.Collections;

public class Lesson2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string menu = "save as";

		switch (menu) {
		case "save":
		case "save as":
			Debug.Log ("保存します");
			break;
		case "open":
			Debug.Log ("開きます");
			break;
		case "print":
			Debug.Log ("印刷します");
			break;
		default:
			Debug.Log ("一致する機能がありません");
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
