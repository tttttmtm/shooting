using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_out : MonoBehaviour
{
	public Text scoreGUI;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		scoreGUI.text = "Score : "+s_shooting.score.ToString ();
	}
}
