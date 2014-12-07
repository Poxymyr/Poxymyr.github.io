using UnityEngine;
using System.Collections;

public class enemyDeathBehaviour : MonoBehaviour {

	private float time = 0;
	private float lifetime = 3;
	// Update is called once per frame
	void Update () {
	
		time += Time.deltaTime;
		if (time > lifetime) {
			enabled = false;
			Destroy(gameObject);
		}
	}
}
