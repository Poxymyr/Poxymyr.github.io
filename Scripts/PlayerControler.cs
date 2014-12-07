using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {

	public float maxSpeed = 5f;
	public GameObject bullet;

	private bool isFiring = false;
	private float chrono = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float bulletSpeed = 2000f;
		chrono += Time.deltaTime;

		//moving
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, Input.GetAxis ("Vertical") * maxSpeed);
		rigidbody2D.velocity = new Vector2 (Input.GetAxis ("Horizontal") * maxSpeed, rigidbody2D.velocity.y);

		//rotation
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 0f;
		
		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		
		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

		//firing
		if (Input.GetMouseButtonDown (0))
						isFiring = true;
		if (Input.GetMouseButtonUp (0))
						isFiring = false;
		if (isFiring && chrono > 0.3) {
			GameObject clone;
			clone = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
			clone.rigidbody2D.AddForce(transform.TransformDirection(Vector3.right * bulletSpeed));
			chrono = 0;
		}
	}
}
