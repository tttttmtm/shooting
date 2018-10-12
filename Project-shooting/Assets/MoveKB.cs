using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKB : MonoBehaviour {


	private Vector3 initialPosition;
	private int hit = 0;
	private int HP = 1;
	private int count = 0;
	private Vector3 nowPosition;
	private int random = 0;
	private float speed = 10.0f;
	private int flag=0;
	private int move = 0;
	private Vector3 destination;
	private Vector3 start;
	private bool arrived = false;
	private bool arrive = false;

	void Start () {
		start = new Vector3 (-39.2f, -0.9f, -124.9f);
		destination = new Vector3 (-39.4f, -0.9f, -179.9f);
		initialPosition = transform.position;
	}

	void Update () {
		if (hit < HP) {
			nowPosition = transform.position;
			if(Vector3.Distance(transform.position, destination) < 0.5f) {
				arrived = true;
				count = 0;
			}
			if (arrived) {
				if (count > 5) {
					move = 1;
					arrived = false;
				}
				nowPosition = transform.position;
				transform.position = new Vector3 (nowPosition.x, nowPosition.y, nowPosition.z);
			}
			if(Vector3.Distance(transform.position, start) < 0.5f) {
				arrive = true;
				count = 0;
			}
			if (arrive) {
				if (count > 5) {
					move = 0;
					arrive = false;
				}
				nowPosition = transform.position;
				transform.position = new Vector3 (nowPosition.x, nowPosition.y, nowPosition.z);
			}
			if (move == 0) {
				speed = 10.0f;
				transform.position += transform.right * speed * Time.deltaTime;
			} else if (move == 1) {
				speed = 15.0f;
				transform.position -= transform.right * speed * Time.deltaTime;
			}
		} else if(flag == 0){
			flag = 1;
			GetComponent<Animator>().SetTrigger ("deathtrigger");
			Destroy(this.gameObject,3.0f);
			/*float x = 90;
				nowPosition = transform.position;
			transform.position = new Vector3 (nowPosition.x, nowPosition.y, nowPosition.z);
				transform.rotation = Quaternion.Euler (x, 0.0f, 0.0f);*/
		}
		count++;
		Debug.Log (transform.position);
	}

	private void OnCollisionEnter( Collision collision ){
		if (collision.gameObject.name == "bullet(Clone)") {
			hit++;
			Debug.Log (hit);
		}
	}
}