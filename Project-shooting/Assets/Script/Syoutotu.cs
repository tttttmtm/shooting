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
			rb.AddForce(Vector3.forward * thrust, ForceMode.Impulse);
		}
	}
	void OnCollisionEnter(Collision other)
	{
		Debug.Log (other.gameObject.name + "Enter");
	}

	// 衝突離脱の判定
	void OnCollisionExit(Collision other)
	{
		Debug.Log (other.gameObject.name + "Exit");
	}
}
