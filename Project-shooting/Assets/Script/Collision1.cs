using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision1 : MonoBehaviour {
	// Use this for initialization
	//public GameObject sc;
	public int score;

	void Start () {
		Debug.Log ("スタートしました");
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Black") {
			score = score + 30;
		} else if (collision.gameObject.name == "Red") {
			score = score + 50;
		} else if (collision.gameObject.name == "Yellow") {
			score = score + 100;
		} else if (collision.gameObject.name == "Blue") {
			score = score + 10;
		} else if (collision.gameObject.name == "Green") {
			score = score + 5;
		} else {
			score = score;
		}
		Debug.Log (score + "  " + collision.gameObject.name);
	}
}
