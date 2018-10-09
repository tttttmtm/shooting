using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision1 : MonoBehaviour {
	// Use this for initialization

	public static bool Bunny_easy=false;
	public static bool Bunny_hard=false;
	public static bool zou_easy=false;
	public static bool zou_hard=false;
	public static bool ahiru=false;
	public static bool piero=false;
	public static bool Bunny_metal=false;

	void Start () {
		Debug.Log ("スタートしました");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Bunny_easy") {
			if (Bunny_easy == false) {
				s_shooting.score = s_shooting.score + 30;
				Bunny_easy = true;
			}
		} else if (collision.gameObject.name == "Bunny_hard") {
			if (Bunny_hard == false) {
				s_shooting.score = s_shooting.score + 50;
				Bunny_hard = true;
			}
		} else if (collision.gameObject.name == "zou_hard") {
			if (zou_hard == false) {
				s_shooting.score = s_shooting.score + 100;
				zou_hard = true;
			}
		} else if (collision.gameObject.name == "zou_easy") {
			if (zou_easy == false) {
				s_shooting.score = s_shooting.score + 10;
				zou_easy = true;
			}
		} else if (collision.gameObject.name == "ahiru") {
			if (ahiru == false) {
				s_shooting.score = s_shooting.score + 5;
				ahiru = true;
			}
		} else if (collision.gameObject.name == "piero") {
			if (piero == false) {
				s_shooting.score = s_shooting.score + 5;
				piero = true;
			}
		}else if (collision.gameObject.name == "Bunny_metal") {
			if (Bunny_metal == false) {
				s_shooting.score = s_shooting.score + 100;
				Bunny_metal = true;
			}
		} else {
			
		}
		Debug.Log (s_shooting.score + "  " + collision.gameObject.name);
	}
}
