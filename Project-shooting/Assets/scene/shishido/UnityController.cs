using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityController : MonoBehaviour {

	public float speed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.R)){
			TurnRight();
		}
		if(Input.GetKeyDown (KeyCode.L)){
			TurnLeft();
		}
		if(Input.GetKeyDown (KeyCode.W)){
			Walk();
		}
	}

	void TurnLeft(){
		transform.Rotate (new Vector3 (0, -5, 0));
	}

	void TurnRight(){
		transform.Rotate (new Vector3 (0, 5, 0));
	}

	void Walk(){
		transform.position += transform.forward * speed * Time.deltaTime;
	}
}
