using UnityEngine;
using System.Collections;

public class pieceController : MonoBehaviour
{

		public bool goal = false;

		bool stopDragging;
		bool drag;
		bool isMouseUp = false;
		Vector3 startPos;
		Vector3 offset;

		// Use this for initialization
		void Start ()
		{
				Initalize ();
		}
	
		// Update is called once per frame
		void Update ()
		{
	
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
						this.transform.position = startPos;
				}
		}

		void Initalize ()
		{
				stopDragging = false;
				drag = false;
				startPos = transform.position;

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
						if (drag && !stopDragging) {
								Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
								Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
								transform.position = curPosition;

						}
				}
		}

		void OnMouseUp ()
		{
				if (goal == false) {
						drag = false;
						isMouseUp = true;
				}
		}
}
