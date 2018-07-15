using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour {

	public float increment = 10f;
	public int rotation = 1;
	public bool deathstar = false;

	// Update is called once per frame
	void Update () {
	//	if (Input.GetMouseButtonUp(0)) {
		//	rotation *= -1;
		//} 

		if (deathstar) {
			transform.Rotate (Vector3.up, increment * Time.deltaTime * rotation, Space.Self);
		} else {
			increment += 5f;
			if (increment == 360) {
				increment = 0;
			}
			transform.localEulerAngles = new Vector3 (0, increment, -40.064f);
		}
	}
}
