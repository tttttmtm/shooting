using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movefloorcos2 : MonoBehaviour {


	private Vector3 initialPosition;
	private int hit = 0;
	private int HP = 5;
	private int count = 0;
	private Vector3 nowPosition;
	private int random = Random.Range(0, 4);

	void Start () {

		initialPosition = transform.position;

	}

	void Update () {
		if (count > 15) {
			random = Random.Range (0, 4);
			//initialPosition = transform.position;
			count = 0;
		}else{
		if (hit < HP) {
				if (random == 0) {
					transform.position += transform.right * 20.0f * Time.deltaTime;
				} else if (random == 1) {
					transform.position += transform.forward * 20.0f * Time.deltaTime;
				} else if (random == 2) {
					transform.position -= transform.right * 20.0f * Time.deltaTime;
				} else if (random == 3) {
					transform.position -= transform.forward * 20.0f * Time.deltaTime;
				}
		} else {
			float x = 90;
			nowPosition = transform.position;
			transform.position = new Vector3 (nowPosition.x, 0.39f, nowPosition.z);
			transform.rotation = Quaternion.Euler (x, 0.0f, 0.0f);
		}
	}
		count++;
	}

	private void OnCollisionEnter( Collision i_collision ){
		hit++;
	}
}