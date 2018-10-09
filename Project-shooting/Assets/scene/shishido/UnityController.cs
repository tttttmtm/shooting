using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityController : MonoBehaviour {

	public float speed = 10;
    public float turnspeed = 1.0f;
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
            GoForward();
		}
        if (Input.GetKeyDown(KeyCode.B))
        {
            GoBack();
        }
    }

	public void TurnLeft(){
		transform.Rotate (new Vector3 (0, -turnspeed, 0));
	}

    public void TurnRight(){
		transform.Rotate (new Vector3 (0, turnspeed, 0));
	}

    public void GoForward(){
		transform.position += transform.forward * speed * Time.deltaTime;
	}

    public void GoBack()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }
}
