using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
	public GameObject m_Animator;
	public GameObject m_light;
	public AudioSource m_audio;

	void Awake()
	{
		//Get the animator, attached to the GameObject you are intending to animate.
		m_Animator.GetComponent<Animator>().speed = 0.8f;
	}

	void Update()
	{
		if (m_audio.isPlaying == false){
			m_light.SetActive (false);
		}else{
			//m_light.SetActive (false);
		}
	}

	bool AnimatorIsPlaying(){
		return m_Animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).length > m_Animator.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).normalizedTime;
	}

}