using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDina : MonoBehaviour {

	public GameObject dinaContent;
	public int textNumber = 0;

	public GameObject TextObj1;
	public GameObject TextObj2;
	public GameObject TextObj3;

	// Use this for initialization
	void Start () {
		
	}

	void Update() {
		if (Input.GetMouseButtonUp(0)) {
			dinaContent.SetActive (true);
			this.gameObject.SetActive (false);
			ScreenController.Instance.ShowInfo (textNumber);
			//
			//
			//TextObj.SetActive (true);
			//TextObj.GetComponent<Text>().text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			//TextObj.GetComponent<TextManager>().setTextString(textNumber);


		}
	}
}
