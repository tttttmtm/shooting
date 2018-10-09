using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityController : MonoBehaviour {

	public float speed = 1000;
	public float turnspeed = 1.0f;
    int state = 2;
     

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
		} else {
            //GetComponent<Animator>().SetTrigger("Idle");
        }
    }

	public void TurnLeft(){
		transform.Rotate (new Vector3 (0, -turnspeed, 0));
	}

    public void TurnRight(){
		transform.Rotate (new Vector3 (0, turnspeed, 0));
	}
    public void GoForward()
    {
        GetComponent<Animator>().SetTrigger("walk");
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void GoBack()
    {
        GetComponent<Animator>().SetTrigger("walkback");
        transform.position -= transform.forward * speed * Time.deltaTime;
    }

    public void Idle()
    {
        GetComponent<Animator>().SetTrigger("Idle");
    }
}

//    public void GoForward(){
//        if (state == 0)
//        {
//            //GetComponent<Animator>().ResetTrigger("Idle");
//            GetComponent<Animator>().SetTrigger("walk");
//            state = 1;
//        }
//        else if (state == 2) {
//            //GetComponent<Animator>().ResetTrigger("walkback");
//            GetComponent<Animator>().SetTrigger("Idle");
//            state = 0;
//        }

//        transform.position += transform.forward * speed * Time.deltaTime;
//	}

//    public void GoBack(){
//        if (state == 0)
//        {
//            //GetComponent<Animator>().ResetTrigger("Idle");
//            GetComponent<Animator>().SetTrigger("walkback");
//            state = 2;
//        }
//        else if (state == 1)
//        {
//            //GetComponent<Animator>().ResetTrigger("walk");
//            GetComponent<Animator>().SetTrigger("Idle");
//            state = 0;
//        }
//        transform.position -= transform.forward * speed * Time.deltaTime;
//	}

//    public void Idle() {
//        if(state != 0)
//        {
//            GetComponent<Animator>().SetTrigger("Idle");
//            state = 0;
//        }
//    }
//}
