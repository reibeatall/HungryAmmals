using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class countdownTimer : MonoBehaviour
{

		public float timeRemaining = 60;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				timeRemaining -= Time.deltaTime;
		}
}
