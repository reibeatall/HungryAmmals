﻿using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour
{


	
		// Update is called once per frame
		public void ExitGame ()
		{
				Debug.Log ("exit game");
				Application.Quit ();
		}
}
