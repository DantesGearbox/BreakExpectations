using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKilled : MonoBehaviour{
	
	public Transform resetTransform;
	public bool kill = true;
	public bool reset = false;

	PlaySounds playSounds;

	private void Start() {
		playSounds = FindObjectOfType<PlaySounds>();
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "DangerSpikes") {
			if (kill) {
				transform.position = resetTransform.position;
			}
			if (reset) {
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			}

			playSounds.PlayDeath();
		}
	}
}