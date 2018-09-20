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
	private float maxX, minX, maxZ, minZ;

	void Start () {

		initialPosition = transform.position;
		maxX = initialPosition.x + 10.0f;
		minX = initialPosition.x - 10.0f;
		maxZ = initialPosition.z + 10.0f;
		minZ = initialPosition.z - 10.0f;

	}

	void Update () {
		if (count > 15) {
			random = Random.Range (0, 4);
			count = 0;
		}else{
		if (hit < HP) {
				nowPosition = transform.position;
				if (count > 15) {
					random = Random.Range (0, 4);
					count = 0;
				}else if (random == 0) {
					if (maxX > nowPosition.x) {
						transform.position += transform.right * 20.0f * Time.deltaTime;
					}else transform.position -= transform.right * 30.0f * Time.deltaTime;

					} else if (random == 1) {
					if (maxZ > nowPosition.z) {
						transform.position += transform.forward * 20.0f * Time.deltaTime;
					}else transform.position -= transform.forward * 30.0f * Time.deltaTime;
						
					} else if (random == 2) {
					if (minX > nowPosition.x) {
						transform.position -= transform.right * 20.0f * Time.deltaTime;
					}else transform.position += transform.right * 30.0f * Time.deltaTime;

					} else if (random == 3) {
					if (minZ > nowPosition.z) {
						transform.position -= transform.forward * 20.0f * Time.deltaTime;
					}else transform.position += transform.forward * 30.0f * Time.deltaTime;
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