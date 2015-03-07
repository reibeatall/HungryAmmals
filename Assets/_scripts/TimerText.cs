using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{

		public Text timerText;
		public float timeRemaining = 60;
		
		// Use this for initialization
	
	
		void Start ()
		{
				timerText = GetComponent<Text> ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				timeRemaining -= Time.deltaTime;
				timerText.text = " " + (int)timeRemaining;
				
				if (timeRemaining <= 0) {
						Debug.Log ("time's up!");

						Application.LoadLevel (0);
				}
		}


}


