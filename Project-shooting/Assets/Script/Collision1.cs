using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision1 : MonoBehaviour {
	// Use this for initialization

	void Start () {
		Debug.Log ("スタートしました");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Black") {
			Score.score = Score.score + 30;
		} else if (collision.gameObject.name == "Red") {
			Score.score = Score.score + 50;
		} else if (collision.gameObject.name == "Yellow") {
			Score.score = Score.score + 100;
		} else if (collision.gameObject.name == "Blue") {
			Score.score = Score.score + 10;
		} else if (collision.gameObject.name == "Green") {
			Score.score = Score.score + 5;
		} else {
			
		}
		Debug.Log (Score.score + "  " + collision.gameObject.name);
	}
}
