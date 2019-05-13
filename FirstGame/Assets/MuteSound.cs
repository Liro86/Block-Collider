using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSound : MonoBehaviour {

	AudioSource cSS;
	public Rigidbody rb;
	public AudioClip backgroundSound;
	// Use this for initialization
	void Start () {
		cSS = GetComponent<AudioSource>();
		cSS.PlayOneShot(backgroundSound);		
	}
	
	// Update is called once per frame
	void Update() {
		if (rb.position.z > 1005){
		cSS.mute = true;
		}
	}
}
