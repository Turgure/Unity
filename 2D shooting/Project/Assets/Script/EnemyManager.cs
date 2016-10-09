using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
	public GameObject enemyPrefab;
	public UnityEngine.UI.Text TimerLabel;

	private int time = 0;
	private int keyID = 0;
	private int[,] table = {
		{ 2, 3 },
		{ 6, 3 },
		{ 10, 5 },
		{ 15, 5 },
		{ 20, 5 },
		{ 25, 5 },
		{ 30, 8 },
		{ 36, 8 },
		{ 42, 8 },
		{ 48, 8 },
		{ 54, 8 },
		{ 60, 15 },
		{ 65, 15 },
		{ 70, 15 },
		{ 75, 15 },
		{ 80, 15 },
		{ 85, 15 },
		{ 90, 15 },
		{ 95, 15 },
		{ 100, 30 },
		{ 110, 30 },
		{ 120, 30 },
		{ 130, 30 },
		{ 140, 30 },
		{ 150, 30 },
		{ 160, 30 },
		{ 170, 30 },
		{ 180, 30 },
		{ 190, 30 },
		{ 200, 60 },
		{ 210, 60 },
		{ 220, 60 },
		{ 230, 60 },
		{ 240, 60 },
		{ 250, 60 },
		{ 260, 60 },
		{ 270, 60 },
		{ 280, 60 },
		{ 290, 60 },
		{ 300, 60 },
		{ 325, 60 },
		{ 365, 60 },
		{ 425, 60 },
		{ 465, 60 },
		{ 500, 100 },
		{ 550, 100 },
		{ 600, 100 },
		{ 650, 100 },
		{ 700, 100 },
		{ 750, 100 },
		{ 800, 100 },
		{ 850, 100 },
		{ 900, 100 },
		{ 950, 100 },
		{ 1000, 100 },
	};

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		if(table[keyID, 0] == time / 60) {
			for(int i = 0; i < table[keyID, 1]; ++i) {
				Instantiate(enemyPrefab, new Vector3(10.5f, MyRandom.nextDouble(3.5f), 0f), Quaternion.identity);
			}
			++keyID;
		}

		++time;
		TimerLabel.text = "Time:" + time / 60;
	}
}
