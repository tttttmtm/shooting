using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_shooting : MonoBehaviour {

	// bullet prefab
	public GameObject bullet;

	// 弾丸発射点
	public Transform muzzle;

	// 弾丸の速度
	public float speed = 1000;
	//public int count;

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello");
	}

	// Update is called once per frame
	void Update () {
		// z キーが押された時
		if(Input.GetKeyDown (KeyCode.Z)){
				// 弾丸の複製
			GameObject bullets = GameObject.Instantiate (bullet) as GameObject;

				//count++;

				Vector3 force;
				force = this.gameObject.transform.up * speed;
				// Rigidbodyに力を加えて発射
				bullets.GetComponent<Rigidbody> ().AddForce (force);
				// 弾丸の位置を調整
				bullets.transform.position = muzzle.position;

		}
	}

	void OnCollisionEnter(Collision other) {
		Debug.Log (/*other.gameObject.name + */"Enter");
	}
	void OnTriggerEnter(Collider t) {
		Debug.Log (/*t.gameObject.name + */"Enter");
	}
}