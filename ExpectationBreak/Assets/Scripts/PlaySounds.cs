using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{

	public AudioSource audio1;
	public AudioSource audio2;
	public AudioSource audio3;


	// Start is called before the first frame update
	void Start()
    {
		DontDestroyOnLoad(this.gameObject);
	}

	public void PlayPling() {
		audio1.Play();
	}

	public void PlayJump() {
		audio2.Play();
	}

	public void PlayDeath() {
		audio3.Play();
	}
}
