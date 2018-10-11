using System.Collections;
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
	public Transform Bunny_easyt;
	public Transform Bunny_metalt;
	public Transform zou_hardt;
	public Transform zou_easyt;
	public Transform ahirut;
	public Transform pierot;

	// Use this for initialization
	void Start () {
		if(Collision1.Bunny_hard == true) make_Bunny_hard();
		if(Collision1.Bunny_easy == true) make_Bunny_easy();
		if(Collision1.Bunny_metal == true) make_Bunny_metal();
		if(Collision1.zou_hard == true) make_zou_hard();
		if(Collision1.zou_easy == true) make_zou_easy();
		if(Collision1.ahiru == true) make_ahiru();
		if(Collision1.piero == true) make_piero();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void make_Bunny_hard(){
		GameObject Bunny_hardp = GameObject.Instantiate (Bunny_hard) as GameObject;
		Bunny_hardp.transform.position = Bunny_hardt.position;
	}
	void make_Bunny_easy(){
		GameObject Bunny_easyp = GameObject.Instantiate (Bunny_easy) as GameObject;
		Bunny_easyp.transform.position = Bunny_hardt.position;
	}
	void make_zou_hard(){
		GameObject zou_hardp = Object.Instantiate (zou_hard) as GameObject;
		zou_hardp.transform.position = Bunny_hardt.position;
	}
	void make_zou_easy(){
		GameObject zou_easyp = GameObject.Instantiate (zou_easy) as GameObject;
		zou_easyp.transform.position = Bunny_hardt.position;
	}
	void make_ahiru(){
		GameObject ahirup = GameObject.Instantiate (ahiru) as GameObject;
		ahirup.transform.position = Bunny_hardt.position;
	}
	void make_piero(){
		GameObject pierop = GameObject.Instantiate (piero) as GameObject;
		pierop.transform.position = Bunny_hardt.position;
	}
	void make_Bunny_metal(){
		GameObject Bunny_metalp = GameObject.Instantiate (Bunny_metal) as GameObject;
		Bunny_metalp.transform.position = Bunny_hardt.position;
	}
}
