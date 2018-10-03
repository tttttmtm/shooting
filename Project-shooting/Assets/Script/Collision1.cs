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
		if (collision.gameObject.name == "Bunny_easy") {
			s_shooting.score = s_shooting.score + 30;
		} else if (collision.gameObject.name == "Bunny_hard") {
			s_shooting.score = s_shooting.score + 50;
		} else if (collision.gameObject.name == "zou_hard") {
			s_shooting.score = s_shooting.score + 100;
		} else if (collision.gameObject.name == "zou_easy") {
			s_shooting.score = s_shooting.score + 10;
		} else if (collision.gameObject.name == "ahiru") {
			s_shooting.score = s_shooting.score + 5;
		} else if (collision.gameObject.name == "piero") {
			s_shooting.score = s_shooting.score + 5;
		} else {
			
		}
		Debug.Log (s_shooting.score + "  " + collision.gameObject.name);
	}
}
