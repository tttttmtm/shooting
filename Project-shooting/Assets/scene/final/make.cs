﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make : MonoBehaviour {

	public GameObject Bunny_hard;
	public GameObject Bunny_easy;
	public GameObject Bunny_metal;
	public GameObject zou_hard;
	public GameObject zou_easy;
	public GameObject piero;
	public GameObject ahiru;

	public Transform Bunny_hardt;

	// Use this for initialization
	void Start () {
		if(Collision1.Bunny_hard == true) make_Bunny_hard();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void make_Bunny_hard(){
		GameObject Bunny_hardp = GameObject.Instantiate (Bunny_hard) as GameObject;
		Bunny_hardp.transform.position = Bunny_hardt.position;
	}
}