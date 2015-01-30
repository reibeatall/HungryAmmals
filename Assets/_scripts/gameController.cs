using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameController : MonoBehaviour
{

		public bool gameOver = false;
		public Vector3 topSpawn;
		public Vector3 midSpawn;
		public Vector3 botSpawn;
		public Vector3 goalSpawn;
		public List<GameObject> blockPool;
		public List<GameObject> goalPool;
		public List<Sprite> spritePool;
		public GameObject body;
	public int score;
	

		// Use this for initialization
		void Start ()
		{
				//goalPool.Capacity = 3;
				SpawnRandBlock (topSpawn);
				SpawnRandBlock (midSpawn);
				SpawnRandBlock (botSpawn);
				SpawnGoalBlock (goalSpawn);
		score = 0;
		}
		
	
		// Update is called once per frame
		void Update ()
		{
		
		}
		
		void SpawnRandBlock (Vector3 spawn)
		{
				int RandIndex = Random.Range (0, blockPool.Count);
				int RandSprite = Random.Range (0, spritePool.Count);
				GameObject piece = Instantiate (body) as GameObject;
				piece.transform.position = spawn;
				piece.GetComponent<SpriteRenderer> ().sprite = spritePool [RandSprite];
				spritePool.Remove (spritePool [RandSprite]);
				goalPool.Add (piece);
				blockPool.Remove (blockPool [RandIndex]);
				piece.name = (goalPool.Count).ToString ();
		} 
		void SpawnGoalBlock (Vector3 spawn)
		{
				int RandIndex = Random.Range (0, goalPool.Count);
				GameObject goal = Instantiate (goalPool [RandIndex]) as GameObject;
				goal.transform.position = spawn;
				goal.GetComponent<pieceController> ().goal = true;
				//Save this line for when I spawn objects that are different shapes
				goal.renderer.material.color = Color.black;
		
		}
}
