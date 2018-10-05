using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TurnLeft(){
		transform.Rotate (new Vector2 (0, 5, 0));
	}

	void TurnRight(){
		transform.Rotate (new Vector2 (0, -5, 0));
	}

	void Walk(){
		
	}
}
