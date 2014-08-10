using UnityEngine;
using System.Collections;

public class pieceController : MonoBehaviour
{

	public bool goal = false;

	bool stopDragging;
	bool drag;
	bool isMouseUp = false;
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
		if (drag == true) {
			Destroy (other.gameObject);
			Application.LoadLevel (0);
		}
	}

	void Initalize ()
	{
		stopDragging = false;
		drag = false;

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
