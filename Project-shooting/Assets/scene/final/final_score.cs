using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class final_score : MonoBehaviour {

	public Text finalGUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		finalGUI.text = "Score : "+ s_shooting.score.ToString ();
	}
}
