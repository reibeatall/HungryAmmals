using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreText : MonoBehaviour
{


		public Text score;
		private scoreController scoreController;

		// Use this for initialization
		void Start ()
		{
				score = GetComponent<Text> (); 
				GameObject scoreControllerObject = GameObject.FindGameObjectWithTag ("score");
				scoreController = scoreControllerObject.GetComponent<scoreController> ();

		}
	
		// Update is called once per frame
		void Update ()
		{
				score.text = "" + scoreController.score.ToString ();

		}
}
