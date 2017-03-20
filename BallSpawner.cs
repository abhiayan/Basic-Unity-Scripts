using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;


	// Use this for initialization
	void Start () {
		Instantiate (ballPrefab);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.left * 25f ;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.right* 25f ;
		}
		if (Input.GetButtonDown("Fire1")) {
			GameObject instance = Instantiate (ballPrefab);
			instance.transform.position = transform.position; //transform.position will give location of the game object on which this script is applied which in this happens to be the camera.
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.forward*25f ;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.back*25f ;
		}
	
	}
}
