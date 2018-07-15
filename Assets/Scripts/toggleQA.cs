using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleQA : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void Update() {
		if (Input.GetMouseButtonUp(0)) {
			this.gameObject.SetActive (false);
			ScreenController.Instance.QAButtonClick ();
			//
			//
			//TextObj.SetActive (true);
			//TextObj.GetComponent<Text>().text = "The opera singer Emilie Ambre was a neighbor of Manet. She played the title role of George Bizet's Carmen which debuted in 1875.";
			//TextObj.GetComponent<TextManager>().setTextString(textNumber);


		}
	}
}
