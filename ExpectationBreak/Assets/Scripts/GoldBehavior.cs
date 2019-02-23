using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBehavior : MonoBehaviour{

	ParticleSystem ps;
	SpriteRenderer sr;

	bool dead = false;

	// Start is called before the first frame update
	void Start() {
		sr = GetComponent<SpriteRenderer>();
		ps = GetComponent<ParticleSystem>();
	}

	private void OnTriggerEnter2D(Collider2D collision) {

		if (!dead) {
			sr.enabled = false;
			ps.Play();
			dead = true;
		}

	}
}