using System.Collections;
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
	public bool flag = false;

	// Use this for initialization
	void Start ()
	{
		minute = 0;
		seconds = 59f;
		oldseconds = 59f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		seconds = seconds - Time.deltaTime;
		if (seconds < 0f) {
			flag = true;
			Debug.Log ("通過");
		}
		if(seconds < 0f) {
			minute--;
			seconds = seconds + 59f;
		}
		//　値が変わった時だけテキストUIを更新
		if((int)seconds != (int)oldseconds && flag == false) {
			scoreGUI.text = "残り時間 : " + minute.ToString("00") + ":" + ((int) seconds).ToString ("00");

		}
		oldseconds = seconds;
		        
	}
	
}
