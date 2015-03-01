using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highScoreController : MonoBehaviour {

	public Text highScoreText;
	private scoreController scoreController;
	public int highScore;
	string highScoreKey = "HighScore";
	
	// Use this for initialization
	void Start () {
		highScoreText = GetComponent<Text>();
		//GameObject scoreControllerObject = GameObject.FindGameObjectWithTag("highscore");
		//scoreController = scoreController
		highScore = PlayerPrefs.GetInt(highScoreKey, 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		//highScore.text = "High Score: " + PlayerPrefs.GetInt(hi;
		highScoreText.text = "High Score: " + highScore;
		
	}
}