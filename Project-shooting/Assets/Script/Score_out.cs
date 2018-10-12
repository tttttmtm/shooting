using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_out : MonoBehaviour
{
	public Text scoreGUI;
	public int time = 120;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Invoke("text",5);
	}

	void text(){
		scoreGUI.text = "残り時間 : "+ time.ToString ();
		time = time - 1;
	}
}
