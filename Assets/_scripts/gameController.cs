using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour
{

		public bool gameOver = false;
		public Vector3 topSpawn;
		public Vector3 midSpawn;
		public Vector3 botSpawn;
		public Vector3 goalSpawn;
		public GameObject[] blockPool = new GameObject[3];
		private GameObject[] goalPool = new GameObject[3];
//	 GameObject topPiece;
		//private midPiece;
		//private botPiece;
		//private goalPiece;


//	private void spawnPiece ( GameObject piece, float xPos, float yPos ) 
//	{
//		newPiece = Instantiate (piece);
//		piece.transform.position = new Vector3 (xPos, yPos, 0);
//		}

//	private void spawnGoal ( GameObject piece, float xPos, float yPos)
//	{

//		spawnPiece (piece, xPos, yPos);
//		piece.GetComponent<pieceController>().goal = true;

		//piece.renderer.sharedMaterial.color = Color.white;
//	}

		// Use this for initialization
		void Start ()
		{
				GameObject topPiece = Instantiate (blockPool [0]) as GameObject;
				topPiece.transform.position = topSpawn;
				GameObject midPiece = Instantiate (blockPool [1]) as GameObject;
				midPiece.transform.position = midSpawn;
				GameObject botPiece = Instantiate (blockPool [2]) as GameObject;
				botPiece.transform.position = botSpawn;
				goalPool [0] = topPiece;
				goalPool [1] = midPiece;
				goalPool [2] = botPiece;
				Debug.Log (goalPool [0]);
				GameObject goal = Instantiate (goalPool [Random.Range (0, 3)]) as GameObject;
				goal.GetComponent<pieceController> ().goal = true;
				goal.transform.position = goalSpawn;

				//			spawnPiece(blueObj, -3, 3);
//			spawnPiece (redObj, -3, 0);
//		spawnPiece (yellowObj, -3, -3);
//		spawnGoal (blueObj, 3, 0);
				//Instantiate (pieceobj, new Vector3 (10, 10, 0), Quaternion.identity);
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
}
