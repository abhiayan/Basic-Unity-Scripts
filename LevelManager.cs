using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float timeTillNextLevel = 5.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timeTillNextLevel -= Time.deltaTime;

		if (timeTillNextLevel<0) {
			LoadNextScene ();
		}

	}

		public void LoadNextScene()
		{
			int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		if (currentIndex == 2) {
			SceneManager.LoadScene (currentIndex - 1);
		}
		else if (currentIndex != 2) {
			SceneManager.LoadScene (currentIndex + 1);

		}
		}
}
