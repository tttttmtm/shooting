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

	public GameObject[] bullets = new GameObject[1000];

	public int count = 0;

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello");
	}

	// Update is called once per frame
	void Update () {
		// z キーが押された時
		if(Input.GetKeyDown (KeyCode.Z)){
				// 弾丸の複製
			bullets[count] = GameObject.Instantiate (bullet) as GameObject;

				//count++;

				Vector3 force;
				force = this.gameObject.transform.up * speed;
				// Rigidbodyに力を加えて発射
				bullets[count].GetComponent<Rigidbody> ().AddForce (force);
				// 弾丸の位置を調整
				bullets[count].transform.position = muzzle.position;

			count++;
		}
	}
	void OnCollisionEnter(Collision collision) {
		Debug.Log (collision.gameObject.name + "Enter");
	}

	//オブジェクトが離れた時
	void OnCollisionExit(Collision collision) {
		Debug.Log (collision.gameObject.name + "Out");
	}

	//オブジェクトが触れている間
	void OnCollisionStay(Collision collision) {
		Debug.Log (collision.gameObject.name + "Stay");
	}
}