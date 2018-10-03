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
	private float speed = 5.0f;
	private int flag=0;
	private int move = 0;
	private Vector3 destination;
	private Vector3 Back;
	private bool arrived = false;
	private bool arrive = false;

	void Start () {
		Back = new Vector3 (-22.6f, -2.4f, -173);
		destination = new Vector3 (-28.7f, 0.1f, -122.6f);
		initialPosition = transform.position;
	}

	void Update () {
		if (hit < HP) {
			nowPosition = transform.position;
			if(Vector3.Distance(transform.position, destination) < 0.5f) {
				arrived = true;
				count = 0;
			}
			if(Vector3.Distance(transform.position, Back) < 0.5f) {
				arrive = true;
				count = 0;
			}
			if (arrived) {
				if (count > 5) {
					move = 1;
				}
				nowPosition = transform.position;
				transform.position = new Vector3 (nowPosition.x, nowPosition.y, nowPosition.z);
			}
			if (arrive) {
				if (count > 5) {
					move = 0;
				}
				nowPosition = transform.position;
				transform.position = new Vector3 (nowPosition.x, nowPosition.y, nowPosition.z);
			}
			if (move == 0) {
				transform.position += transform.right * speed * Time.deltaTime;
			} else if (move == 1) {
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
	}

	private void OnCollisionEnter( Collision i_collision ){
		hit++;
	}
}