using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreManager : MonoBehaviour {

	public static int score;
	public static int finalScore;

	Text text;

	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		score = 0;
	}

	void Update ()
	{
		text.text = ""+score;
	}
}
