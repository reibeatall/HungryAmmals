using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameMusic : MonoBehaviour
{
//		This was here for when I was doing level reload. Not really needed, but want to make sure.	
//		private static GameMusic instance = null;
//		public static GameMusic Instance {
//				get { return instance; }
//		}
//		void Awake ()
//		{
//				if (instance != null && instance != this) {
//						Destroy (this.gameObject);
//						return;
//				} else {
//						instance = this;
//				}
//				DontDestroyOnLoad (this.gameObject);
//		}
	
		public List<AudioClip> musicTracks;
	
	
		void Update ()
		{
				if (!GetComponent<AudioSource>().isPlaying) {
						int RandIndex = Random.Range (0, 5);
						GetComponent<AudioSource>().clip = musicTracks [RandIndex];
						GetComponent<AudioSource>().Play ();
				}
	
		}
	
	
}