using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeSceneOnClickScript : MonoBehaviour {

	public string _nextScene = "";
	private Text text;

	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		text.text = "You lose!\nScore : "+scoreManager.finalScore+"\nClick to try again";
	}

	public void Update()
	{
		if (Input.GetMouseButtonDown(0) || (Input.touches != null && Input.touches.Length > 0))
		{
			Application.LoadLevel(_nextScene);
		}
	}
}
