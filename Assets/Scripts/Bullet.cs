using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 10f;

	private Rigidbody2D myBody;

	void Awake() {
		myBody = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
		Move ();
	}

	void Move() {
		myBody.velocity = new Vector2 (transform.localScale.x, 0) * speed;
	}

	void OnCollisionEnter2D(Collision2D target) {
		if (target.gameObject.tag == "Enemy") {
			Destroy(target.gameObject);
			Destroy (gameObject);
		}
	}

} 