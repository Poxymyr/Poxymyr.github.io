using UnityEngine;
using System.Collections;

public class ApplyForceOnTriggerEnter : MonoBehaviour {

	[SerializeField]
	private Vector3 _force;

	public void OnDrawGizmos()
	{
		Debug.DrawLine(this.transform.position, this.transform.position + _force / Physics.gravity.magnitude, Color.red);
	}

	public void OnTriggerEnter(Collider col)
	{
		if (col.rigidbody != null)
		{
			col.rigidbody.AddForce(_force);
		}
	}
}