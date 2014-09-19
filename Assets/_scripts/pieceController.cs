using UnityEngine;
using System.Collections;

public class pieceController : MonoBehaviour
{

		public bool goal = false;

		bool drag;
		bool isMouseUp = false;
		Vector3 startPos;
		Vector3 offset;
		float x;
		float y;
		

		// Use this for initialization
		void Start ()
		{
				Initalize ();
				//startPos = gameObject.transform.position;
		}
	
		// Update is called once per frame
		void Update ()
		{
				x = Input.mousePosition.x;
				y = Input.mousePosition.y;
		}
		void OnTriggerEnter2D (Collider2D other)
		{
				Debug.Log ("collision!!");
				if (other.CompareTag (this.gameObject.tag)) {
						Destroy (other.gameObject);
						Debug.Log ("game ovhhh");
						Application.LoadLevel (0);
				} else {
						Debug.Log ("Wrong Piece");
						Debug.Log (startPos);
						//this.transform.position = startPos;
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
								//	Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
								//	Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
								//	transform.position = curPosition;
								transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 10.0f));
								Debug.Log (x);
								Debug.Log ("click!");

						}
				}
		}

		void OnMouseUp ()
		{
				if (goal == false) {
						drag = false;
						isMouseUp = true;
						this.transform.position = startPos;
				}
		}
}
