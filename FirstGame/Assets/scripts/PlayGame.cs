using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {

	AudioSource cSS;
	public AudioClip buttonSound;
	// Use this for initialization
	void Start () {
		cSS = GetComponent<AudioSource>();		
	}
	
	public void Play()
	{
		cSS.PlayOneShot(buttonSound);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
