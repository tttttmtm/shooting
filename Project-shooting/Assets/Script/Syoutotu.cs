using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syoutotu : MonoBehaviour {
	public float thrust;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Z)){
			rb.AddForce(Vector3.up * thrust, ForceMode.Impulse);
		}
	}
	void OnCollisionEnter(Collision collision) {
		Debug.Log (collision.gameObject.name + "Enter");
	}

	//オブジェクトが離れた時
	void OnCollisionExit(Collision collision) {
		Debug.Log (collision.gameObject.name + "Out");
	}

	//オブジェクトが触れている間
	void OnCollisionStay(Collision collision) {
		Debug.Log (collision.gameObject.name + "Stay");
	}
}
