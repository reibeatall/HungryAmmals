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

		// Use this for initialization
		void Start ()
		{
				goalPool.Capacity = 3;
				SpawnRandBlock (topSpawn, false);
				SpawnRandBlock (midSpawn, false);
				SpawnRandBlock (botSpawn, false);
				SpawnRandBlock (goalSpawn, true);
				//GameObject topPiece = Instantiate (blockPool [0]) as GameObject;
				//topPiece.transform.position = topSpawn;
				//GameObject midPiece = Instantiate (blockPool [1]) as GameObject;
				//midPiece.transform.position = midSpawn;
				//GameObject botPiece = Instantiate (blockPool [2]) as GameObject;
				//botPiece.transform.position = botSpawn;
				//goalPool [0] = topPiece;
				//goalPool [1] = midPiece;
				//goalPool [2] = botPiece;
				//Debug.Log (goalPool [0]);
				//GameObject goal = Instantiate (goalPool [Random.Range (0, 3)]) as GameObject;
				//goal.GetComponent<pieceController> ().goal = true;
				//goal.transform.position = goalSpawn;
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
		
		void SpawnRandBlock (Vector3 spawn, bool goal)
		{
				if (goal == false) {
						int RandIndex = Random.Range (0, blockPool.Count);
						GameObject piece = Instantiate (blockPool [RandIndex]) as GameObject;
						piece.transform.position = spawn;
						goalPool.Add (blockPool [RandIndex]);
						blockPool.Remove (blockPool [RandIndex]);
				} else {
						int RandIndex = Random.Range (0, goalPool.Count);
						GameObject piece = Instantiate (goalPool [RandIndex]) as GameObject;
						piece.transform.position = spawn;
						piece.GetComponent<pieceController> ().goal = true;

				
				}
					
		} 
}
