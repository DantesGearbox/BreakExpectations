using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour{

	public BoxCollider2D bc2;

	// Start is called before the first frame update
	void Start() {
		transform.localScale = new Vector3(0.5f, 5, 1);
	}
	
    // Update is called once per frame
	void Update() {
		transform.position += new Vector3(0.01f, 0, 0);
	}
}