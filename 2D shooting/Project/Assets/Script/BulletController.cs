using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	public float speed = 0.5f;

	private Vector3 pos;

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		pos = transform.position;
		pos.x += speed;
		transform.position = pos;
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("Bullet::OnTriggerEnter2D");
		if(other.gameObject.CompareTag("Enemy")) {
			Destroy(gameObject);
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		// 画面外に出たら削除
		if( other.gameObject.CompareTag("Field")) {
			Destroy(gameObject);
		}
	}
}
