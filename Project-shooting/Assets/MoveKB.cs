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
	private float maxX, minX, maxZ, minZ;
	private float speed = 5.0f;
	private int flag=0;

	void Start () {

		initialPosition = transform.position;
		maxX = initialPosition.x + 10.0f;
		minX = initialPosition.x - 10.0f;
		maxZ = initialPosition.z + 10.0f;
		minZ = initialPosition.z - 10.0f;

	}

	void Update () {
		if (hit < HP) {
			nowPosition = transform.position;
			if (count > 15) {
				if (random == 0) {
					random = 1;
				} else if (random == 1) {
					random = 0;
				}
				count = 0;
			}
			if (random == 0) {
				transform.position += transform.right * speed * Time.deltaTime;
			} else if (random == 1) {
				transform.position += transform.right * speed * Time.deltaTime;
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