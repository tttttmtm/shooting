using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gcollision : MonoBehaviour {
	public static int gHP;
	// Use this for initialization
	void Start () {
		gHP = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnCollisionEnter( Collision i_collision ){
		gHP--;
	}
}
