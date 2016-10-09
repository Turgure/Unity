using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	public UnityEngine.UI.Text ScoreLabel;

	private static int totalScore = 0;

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		ScoreLabel.text = "Score:" + totalScore;
	}

	public static void AddScore(int score) {
		totalScore += score;
	}
}
