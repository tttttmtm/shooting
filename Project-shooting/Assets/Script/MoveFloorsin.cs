using UnityEngine;
using System.Collections;

public class MoveFloorsin : MonoBehaviour {

	private Vector3 initialPosition;

	void Start () {

		initialPosition = transform.position;

	}

	void Update () {

		transform.position = new Vector3(Mathf.Sin(Time.time) * 50.0f + initialPosition.x, initialPosition.y, initialPosition.z);

	}
}