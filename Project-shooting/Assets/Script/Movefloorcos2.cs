using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movefloorcos2 : MonoBehaviour {


	private Vector3 initialPosition;
	private int hit = 0;
	private int HP = 1;
	private int count = 0;
	private Vector3 nowPosition;
	private int random;
	private float maxX, minX, maxZ, minZ;
	private float speed;
	private int flag=0;
	private void Awake(){
		random = Random.Range (0, 4);
	}
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
				random = Random.Range (0, 4);
				count = 0;
			}
			speed = Random.Range (0, 10) * 5.0f;
			if (random == 0) {
				transform.position += transform.right * speed * Time.deltaTime;
			} else if (random == 1) {
				transform.position += transform.forward * speed * Time.deltaTime;
			} else if (random == 2) {
				transform.position -= transform.right * speed * Time.deltaTime;
			} else if (random == 3) {
				transform.position -= transform.forward * speed * Time.deltaTime;
			}
			speed = 20.0f;
			if (maxX < nowPosition.x) {
				transform.position -= transform.right * speed * Time.deltaTime;
			} else if (maxZ < nowPosition.z) {
				transform.position -= transform.forward * speed * Time.deltaTime;
			} else if (minX > nowPosition.x) {
				transform.position += transform.right * speed * Time.deltaTime;
			} else if (minZ > nowPosition.z) {
				transform.position += transform.forward * speed * Time.deltaTime;
			}
		} else if(flag == 0){
			flag = 1;
			GetComponent<Animator>().SetTrigger ("deathtrigger");
			Destroy(this.gameObject,2.5f);
				/*float x = 90;
				nowPosition = transform.position;
			transform.position = new Vector3 (nowPosition.x, nowPosition.y, nowPosition.z);
				transform.rotation = Quaternion.Euler (x, 0.0f, 0.0f);*/
			}
		count++;
	}

	private void OnCollisionEnter( Collision collision ){
		if (collision.gameObject.name == "bullet(Clone)") {
			hit++;
			Debug.Log (hit);
		}
	}
}