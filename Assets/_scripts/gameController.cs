using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour
{

	public GameObject blueObj;
	public GameObject redObj;
	public GameObject yellowObj;
	public bool gameOver = false;
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
		GameObject topPiece = Instantiate (blueObj) as GameObject;
		topPiece.transform.position = new Vector3 (-3, 3, 0);
		GameObject goal = Instantiate (blueObj) as GameObject;
		goal.GetComponent<pieceController> ().goal = true;
		goal.transform.position = new Vector3 (3, 0, 0);
		//	goal.collider2D.isTrigger = true;
		GameObject midPiece = Instantiate (redObj) as GameObject;
		midPiece.transform.position = new Vector3 (-3, 0, 0);
		GameObject botPiece = Instantiate (yellowObj) as GameObject;
		botPiece.transform.position = new Vector3 (-3, -3, 0);

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
