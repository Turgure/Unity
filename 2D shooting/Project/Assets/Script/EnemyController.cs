using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public GameObject bulletPrefab;
	public float speed = 0.03f;
	public float shotInterval = 1f;

	private const int SCORE = 100;

	private Vector3 pos;
	private float xLimit = 3.5f;
	private bool isMoveUp;
	private float shotTime = 0;

	// Use this for initialization
	void Start() {
		speed += MyRandom.nextInt(0, 4) * 0.01f;
		pos = transform.position;
		shotTime = MyRandom.nextDouble(1f) * shotInterval;
	}

	// Update is called once per frame
	void Update() {
		move();
		shot();
	}

	void move() {
		if(pos.x > xLimit) {
			pos.x -= speed;
			isMoveUp = pos.y <= 0;
		} else {
			pos.x = xLimit;
			pos.y += speed * (isMoveUp ? 1 : -1);
		}

		transform.position = pos;
	}

	void shot() {
		if(pos.x == xLimit) {
			shotTime += Time.deltaTime;
			if(shotTime >= shotInterval) {
				shotTime = 0;
				Instantiate(bulletPrefab, transform.position + new Vector3(-0.2f, 0f, 0f), Quaternion.identity);
			}
		}

	}
	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Bullet")) {
			Destroy(gameObject);

			// 加点
			ScoreManager.AddScore(SCORE);
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		// 画面外に出たら削除
		if(other.gameObject.CompareTag("Field")) {
			Destroy(gameObject);
		}
	}
}
