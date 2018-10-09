﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityController : MonoBehaviour {

	public float speed = 40;
	public float turnspeed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.L)) {
			TurnRight ();
		} else if (Input.GetKeyDown (KeyCode.J)) {
			TurnLeft ();
		} else if (Input.GetKeyDown (KeyCode.I)) {
			GoForward ();
		} else if (Input.GetKeyDown (KeyCode.K)) {
			GoBack ();
		} else {if (Input.GetKeyDown (KeyCode.P)) {
				
				GetComponent<Animator> ().SetTrigger ("Idle");
			}
		}
	}

	public void TurnLeft(){
		transform.Rotate (new Vector3 (0, -turnspeed, 0));
	}

	public void TurnRight(){
		transform.Rotate (new Vector3 (0, turnspeed, 0));
	}

	public void GoForward(){
		GetComponent<Animator>().ResetTrigger ("walk");
		transform.position += transform.forward * speed * Time.deltaTime;
	}

	public void GoBack(){
		GetComponent<Animator>().SetTrigger ("walkback");
		transform.position -= transform.forward * speed * Time.deltaTime;
	}
}
