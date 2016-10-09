using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {
	public float speed = 0.5f;
	public GameObject bulletPrefab;
	public float shotInterval = 0.2f;
	public GameObject lifePrefab;
	public int defaultLife = 3;
	public float immotalTime = 3f;

	private Vector3 pos;
	private bool canShot = true;
	private float shotTime = 0;
	private int life;
	private List<GameObject> lifeList = new List<GameObject>();
	private bool canHit = true;
	private float immotalCount;

	// Use this for initialization
	void Start() {
		life = defaultLife;
		for(int i = 0; i < life; ++i) {
			lifeList.Add((GameObject)Instantiate(lifePrefab, new Vector3(-8f + i * 1f, 3.5f, 0f), Quaternion.identity));
		}
	}

	// Update is called once per frame
	void Update() {
		move();
		shot();
		updateHit();
	}

	void move() {
		// z軸は0
		//transform.position.Set(transform.position.x, transform.position.y, 0f);

		pos = transform.position;
		if(Input.GetKey(KeyCode.RightArrow)) {
			pos.x += speed;
		} else if(Input.GetKey(KeyCode.LeftArrow)) {
			pos.x -= speed;
		}
		if(Input.GetKey(KeyCode.UpArrow)) {
			pos.y += speed;
		} else if(Input.GetKey(KeyCode.DownArrow)) {
			pos.y -= speed;
		}

		transform.position = pos;
	}

	void shot() {
		if(Input.GetKey(KeyCode.Space) && canShot) {
			canShot = false;
			Instantiate(bulletPrefab, transform.position + new Vector3(0.5f, 0f, 0f), Quaternion.identity);
		}

		if(!canShot) {
			shotTime += Time.deltaTime;
			if(shotTime >= shotInterval) {
				shotTime = 0;
				canShot = true;
			}
		}
	}

	void updateHit() {
		if(canHit) {
			GetComponent<SpriteRenderer>().enabled = true;
		} else {
			GetComponent<SpriteRenderer>().enabled = !GetComponent<SpriteRenderer>().enabled;
			immotalCount += Time.deltaTime;
			if(immotalCount >= immotalTime) {
				immotalCount = 0;
				canHit = true;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("EnemyBullet")) {
			if(!canHit) return;

			canHit = false;
			--life;
			Destroy(lifeList[life]);
			lifeList.RemoveAt(life);

			if(life < 0) {
				Debug.Log("you dead");
			}
		}
	}
}
