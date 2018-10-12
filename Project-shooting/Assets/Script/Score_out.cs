﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_out : MonoBehaviour
{
	public Text scoreGUI;
	public int time = 60;
	public int minute;
	public float seconds;
	public float oldseconds;

	// Use this for initialization
	void Start ()
	{
		minute = 1;
		seconds = 0f;
		oldseconds = 0f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (seconds == 0 && minute == 0) {
			return;
		}
		seconds = seconds - Time.deltaTime;
		if(seconds < 0f) {
			minute--;
			seconds = seconds + 59f;
		}
		//　値が変わった時だけテキストUIを更新
		if((int)seconds != (int)oldseconds) {
			scoreGUI.text = "残り時間 : " + minute.ToString("00") + ":" + ((int) seconds).ToString ("00");

		}
		oldseconds = seconds;
		        
	}
	
}
