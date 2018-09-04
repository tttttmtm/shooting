using UnityEngine;
using System.Collections;

public class MoveFloorsin : MonoBehaviour {
	
	private Vector3 initialPosition;
	private int hit = 0;
	private int HP = 10;
	private Vector3 nowPosition;

	void Start () {
		initialPosition = transform.position;

	}

	void Update () {
		if (hit < HP) {
			transform.position = new Vector3 (Mathf.Sin (Time.time) * 50.0f + initialPosition.x, initialPosition.y, initialPosition.z);
		}else{
			float x = 90;
			nowPosition = transform.position;
			transform.position = new Vector3 (nowPosition.x, 0.39f, nowPosition.z);
			transform.rotation = Quaternion.Euler (x, 0.0f, 0.0f);
		}
	}

	private void OnCollisionEnter( Collision i_collision ){
		hit++;
	}
}