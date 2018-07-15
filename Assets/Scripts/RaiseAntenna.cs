using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseAntenna : MonoBehaviour {

	string animateState = "Reset";
	Vector3 startPos;
	Vector3 endPos;

	// Use this for initialization
	void Start () {
		startPos = new Vector3 (transform.position.x, 0.5f,transform.position.z);
		endPos = new Vector3 (transform.position.x, 0.75f,transform.position.z);
		AnimateAntenna ();
	}

	// Update is called once per frame
	void Update () {
		if (animateState == "Animate") {
		    transform.position = Vector3.Lerp (transform.position, endPos, 1f * Time.deltaTime);
		}
	}

	public void AnimateAntenna(){
		animateState = "Animate";
		//transform.position = startPos;
	}

	public void Reset(){
		animateState = "Reset";
		transform.position = new Vector3 (transform.position.x, 0.5f,transform.position.z);
	}
}
