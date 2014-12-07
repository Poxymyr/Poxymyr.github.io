using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	[SerializeField]
	private Object enemy;
	[SerializeField]
	private Camera camera;

	private float chrono = 4;
	private int waveSize = 1;
	private Vector3 ePos;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		chrono += Time.deltaTime;
		if (chrono > 5) {
			chrono = 0;
			newWave();
			waveSize++;
		}


	}

	private void newWave() {
		for (int i = 0; i < Mathf.Sqrt(waveSize); i++) {
			switch(Random.Range(0, 3)) {
			case 0:
				ePos = new Vector3(Random.Range(0, camera.pixelWidth), camera.pixelHeight+16,  0);
				break;

			case 1:
				ePos = new Vector3(Random.Range(0, camera.pixelWidth), -16,  0);
				break;

			case 2:
				ePos = new Vector3(camera.pixelWidth+16, Random.Range(0, camera.pixelHeight),  0);
				break;

			case 3:
				ePos = new Vector3(-16, Random.Range(0, camera.pixelHeight),  0);
				break;

			default:
				break;
			}


			ePos = camera.ScreenToWorldPoint(ePos);
			ePos.z = 0;
			Instantiate(enemy, ePos, Quaternion.Euler(Vector3.zero));
		}
	}
}
