using UnityEngine;
using System.Collections;

public class Lesson1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Person p = new Person ();
		p.firstname = "太郎";
		p.lastname = "山田";
		Debug.Log (p.getFullName ("★"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

class Person{
	public string firstname;
	public string lastname;

	public string getFullName (string separator) {
		return this.lastname + separator + this.firstname;
	}

	public Person (string fn, string ln){
		this.firstname = fn;
		this.lastname = ln;
	}
	public Person (){}
}