using UnityEngine;
using System.Collections;

public class pieceController : MonoBehaviour
{

		public bool goal = false;
		public GameObject restart;
		public Score score;

		bool drag;
		bool isMouseUp = false;
		Vector3 startPos;
		Vector3 offset;
		float x;
		float y;
	public int totalScore;
	private scoreController scoreController;
		

		// Use this for initialization
		void Start ()
		{
		GameObject scoreControllerObject = GameObject.FindGameObjectWithTag("score");
				Initalize ();
		 scoreController = scoreControllerObject.GetComponent<scoreController>();
				//startPos = gameObject.transform.position;
		}
	
		// Update is called once per frame
		void Update ()
		{
				x = Input.mousePosition.x;
				y = Input.mousePosition.y;

		}
		
	
		
		void OnTriggerExit2D (Collider2D other)
		{
				Debug.Log ("collision!!");
				
				if (other.GetComponent<SpriteRenderer> ().sprite == (this.GetComponent<SpriteRenderer> ().sprite) & (isMouseUp == true)) {
			Destroy (other.gameObject); 
						Destroy (GameObject.Find ("Spawn(Clone)"));
						Destroy (GameObject.Find ("1"));
						Destroy (GameObject.Find ("2"));
						Destroy (GameObject.Find ("3"));
						scoreController.addToScore();
						Debug.Log(scoreController.score);
						Victory ();
						score = GetComponent<Score> ();
						score.score += 1;
						Debug.Log (score.score);
						
						//	Application.LoadLevel (0);
				} else {

				}
		}

		void Initalize ()
		{
				drag = false;
				startPos = gameObject.transform.position;

		}
		void OnMouseDown ()
		{
				if (goal == false) {
						isMouseUp = false;
						drag = true;
						offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
				}
		}

		void OnMouseDrag ()
		{
				if (goal == false) {
						if (drag) {
								transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 10.0f));

						}
				}
		}

//Change to IENuemerator for wait for seconds to work 
		void OnMouseUp ()
		{
				//	yield return new WaitForSeconds (1);
				if (goal == false) {
						drag = false;
						isMouseUp = true;
						this.transform.position = startPos;
				}
		}
		
		void Victory ()
		{
				GameObject spawner = Instantiate (restart) as GameObject;
		}
}

