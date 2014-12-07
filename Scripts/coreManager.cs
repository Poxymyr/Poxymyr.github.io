using UnityEngine;
using System.Collections;

public class coreManager : MonoBehaviour {


	[SerializeField]
	private string _deathScene;

	public Sprite core_2;
	public Sprite core_1;

	private int life;
	
	private Animator anim;

	void Start() 
	{
		life = 3;
		anim = GetComponent<Animator> ();
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.rigidbody2D != null && col.CompareTag("Enemy"))
		{
			life--;
			if(life == 0)
			{
				scoreManager.finalScore = scoreManager.score;
				Application.LoadLevel(_deathScene);
			}
			anim.SetInteger("life", life);

			col.gameObject.SetActive(false);
			scoreManager.score--;
		}
	}
}
