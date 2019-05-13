using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleCollision : MonoBehaviour {

	AudioSource cSS;
	public AudioClip collisionSound;
	// Use this for initialization
	void Start() {
		
		cSS = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
		
	void OnCollisionEnter(){
		
		cSS.PlayOneShot(collisionSound);
		
		
    }
	
}
