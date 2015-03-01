using UnityEngine;
using System.Collections;

public class scoreController : MonoBehaviour {

	public int score = 0;
	public int highScore;
	string highScoreKey = "HighScore";

	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetInt(highScoreKey, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (score > highScore) {
			PlayerPrefs.SetInt(highScoreKey, score);
			PlayerPrefs.Save();
		}

	}

	public void addToScore ()
	{
		score += 1;
	}
}
