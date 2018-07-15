using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

	public GameObject Augment1;
	public GameObject Augment2;
	public GameObject Augment3;
	public GameObject SensorObj;

	public void AR1(){
		SensorObj.GetComponent<RaiseAntenna> ().Reset ();
		Augment1.SetActive (true);
		Augment2.SetActive (false);
		Augment3.SetActive (false);
	}

	public void AR2(){
		SensorObj.GetComponent<RaiseAntenna> ().Reset ();
		Augment1.SetActive (false);
		Augment2.SetActive (true);
		Augment3.SetActive (false);
		SensorObj.GetComponent<RaiseAntenna> ().AnimateAntenna ();
	}

	public void AR3(){
		SensorObj.GetComponent<RaiseAntenna> ().Reset ();
		Augment1.SetActive (false);
		Augment2.SetActive (false);
		Augment3.SetActive (true);
	}
}
