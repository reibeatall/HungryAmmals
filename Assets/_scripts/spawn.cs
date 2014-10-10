using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour
{

		public GameObject makeem;

		// Use this for initialization
		void Start ()
		{
				GameObject spawner = Instantiate (makeem) as GameObject;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
