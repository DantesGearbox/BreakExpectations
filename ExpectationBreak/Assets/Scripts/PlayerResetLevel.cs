using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerResetLevel : MonoBehaviour{
	
	public Transform resetTransform;	

	private void OnCollisionEnter2D(Collision2D collision) {
		if(collision.gameObject.tag == "DangerSpikes") {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}