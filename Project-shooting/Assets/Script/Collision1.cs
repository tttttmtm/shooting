using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision1 : MonoBehaviour {
	// Use this for initialization
	public GameObject sc;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		Debug.Log ("Enter"+sc.GetComponent<s_shooting>().count);
	}
}
