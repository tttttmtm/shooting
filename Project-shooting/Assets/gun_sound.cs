using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_sound : MonoBehaviour {
	public AudioClip gun;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Z)){
			GetComponent<AudioSource>().PlayOneShot(gun,1f);
			}
	}
}
