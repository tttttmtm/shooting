using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gHP : MonoBehaviour {

	public Text HPscore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		HPscore.text = gcollision.gHP.ToString ();
	}
}
