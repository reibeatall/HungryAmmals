using UnityEngine;
using System.Collections;

public class GameButton : MonoBehaviour
{
	
		// Update is called once per frame
		public void ChangeToScene (int scene)
		{
				Application.LoadLevel (scene);
		}
	
}
