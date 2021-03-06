using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCalibrate : MonoBehaviour {
	
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	public bool tracking = true;

	// Use this for initialization
	void Start () {
		guiStyle.fontSize = 50; //change the font size
		guiStyle.normal.textColor = Color.white;

		//transform.position = new Vector3 (-0.017f,0.043f, 0.138f);
		//transform.localEulerAngles = new Vector3 (0f, 156.478f, 0.154f);
		//transform.localScale = new Vector3 (0.496f, 0.496f, 0.496f);

	}

	void OnGUI(){
		if (tracking) {
			GUI.Box (new Rect (10, 10, 1200, 240), "Occluder Transform");
			GUI.Label (new Rect (20, 40, 1200, 60), "Position: " + this.transform.position.ToString ("F3"), guiStyle);
			GUI.Label (new Rect (20, 100, 1200, 60), "Rotation: " + this.transform.localEulerAngles.ToString ("F3"), guiStyle);
			GUI.Label (new Rect (20, 160, 1200, 60), "Scale: " + this.transform.localScale.ToString ("F3"), guiStyle);
		}
	}
		
	// Update is called once per frame
	void Update () {
		if (tracking) {
			if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Moved) {
				Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
				transform.Rotate (0, -touchDeltaPosition.x * 0.01f, 0);
				transform.Translate (0, touchDeltaPosition.y * 0.01f, 0);
			} else if (Input.touchCount == 2 && Input.GetTouch (0).phase == TouchPhase.Moved) {
				Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
				transform.localScale = new Vector3 (transform.localScale.x + touchDeltaPosition.y * 0.001f,
													transform.localScale.y + touchDeltaPosition.y * 0.001f, 
													transform.localScale.z + touchDeltaPosition.y * 0.001f);				
			} else if (Input.touchCount == 3 && Input.GetTouch (0).phase == TouchPhase.Moved) {
				Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
				transform.Translate (touchDeltaPosition.x * 0.001f, 0, touchDeltaPosition.y * 0.001f);
			} else if (Input.touchCount == 3 && Input.GetTouch (0).phase == TouchPhase.Moved) {
				//Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
				//transform.Translate (0, -touchDeltaPosition.y * 0.1f, 0);
			}
		}


	}
}
