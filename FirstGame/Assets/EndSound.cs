using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSound : MonoBehaviour {

	AudioSource cSS;
	public AudioClip endSound;
	// Use this for initialization
	void Start () {
		cSS = GetComponent<AudioSource>();		
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		cSS.PlayOneShot(endSound);
	}
}
