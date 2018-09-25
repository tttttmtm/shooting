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
		if (collision.gameObject.name == "E1") {
			s_shooting.score = s_shooting.score + 30;
		} else if (collision.gameObject.name == "E2") {
			s_shooting.score = s_shooting.score + 50;
		} else if (collision.gameObject.name == "E3") {
			s_shooting.score = s_shooting.score + 100;
		} else if (collision.gameObject.name == "E4") {
			s_shooting.score = s_shooting.score + 10;
		} else if (collision.gameObject.name == "E5") {
			s_shooting.score = s_shooting.score + 5;
		} else {
			
		}
		Debug.Log (s_shooting.score + "  " + collision.gameObject.name);
	}
}
