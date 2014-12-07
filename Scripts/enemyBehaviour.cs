using UnityEngine;
using System.Collections;

public class enemyBehaviour : MonoBehaviour {

	[SerializeField]
	private Vector3 _force;
	[SerializeField]
	private GameObject _deathParticle;

	private Vector2 temp;
	private float acceleration;

	void Start () {
		GameObject core = GameObject.FindWithTag ("Core");
		Vector2 vec;
		acceleration = 5f;

		vec.x = core.transform.position.x - rigidbody2D.position.x;
		vec.y = core.transform.position.y - rigidbody2D.position.y;
		vec = vec.normalized;

	}

	public void Update()
	{
		GameObject core = GameObject.FindWithTag ("Core");
		Vector2 vec;
		vec.x = core.transform.position.x - rigidbody2D.position.x;
		vec.y = core.transform.position.y - rigidbody2D.position.y;
		vec = vec.normalized;

		rigidbody2D.AddForce (vec * acceleration);
	}
	
	public void OnLevelWasLoaded() {
		Destroy (gameObject);
	}

	void OnDestroy() 
	{
		enabled = false;
	}

	public void OnBecameInvisible()
	{
		Instantiate (_deathParticle, transform.position, transform.rotation);
		scoreManager.score++;
		enabled = false;
	}
}
