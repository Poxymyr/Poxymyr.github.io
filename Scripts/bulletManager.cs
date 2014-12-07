using UnityEngine;
using System.Collections;

public class bulletManager : MonoBehaviour {

	public void OnBecameInvisible()
	{
		Destroy(gameObject);
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Enemy")
			Destroy (gameObject);

	}
}
