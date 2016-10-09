using UnityEngine;
using System.Collections;

public class EnemyBulletController : MonoBehaviour {
	public float speed = 0.01f;

	private Vector3 pos;
	private float dir;

	// Use this for initialization
	void Start() {
		Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
		dir = Mathf.Atan2(playerPos.y - transform.position.y, playerPos.x - transform.position.x) + MyRandom.nextDouble(Mathf.PI / 24f);
	}

	// Update is called once per frame
	void Update() {
		pos = transform.position;
		pos.x += Mathf.Cos(dir) * speed;
		pos.y += Mathf.Sin(dir) * speed;
		transform.position = pos;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Player")) {
			Destroy(gameObject);
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		// 画面外に出たら削除
		if(other.gameObject.CompareTag("Field")) {
			Destroy(gameObject);
		}
	}
}
