using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour {
	public GameObject Bunny_hard;
	public GameObject Bunny_easy;
	public GameObject Bunny_metal;
	public GameObject zou_hard;
	public GameObject zou_easy;
	public GameObject piero;
	public GameObject ahiru;
	// Use this for initialization
	void Start () {
		if(Collision1.Bunny_hard == false) Destroy(Bunny_hard);
		if(Collision1.Bunny_easy == false) Destroy(Bunny_easy);
		if(Collision1.Bunny_metal == false) Destroy(Bunny_metal);
		if(Collision1.zou_hard == false) Destroy(zou_hard);
		if(Collision1.zou_easy == false) Destroy(zou_easy);
		if(Collision1.ahiru == false) Destroy(ahiru);
		if(Collision1.piero == false) Destroy(piero);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
