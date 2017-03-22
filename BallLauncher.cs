using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {
	
	public GameObject ballPrefab;
	public float ballSpeed = 2.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			GameObject instance = Instantiate (ballPrefab);
			instance.transform.position = transform.position; //transform.position will give location of the game object on which this script is applied which in this happens to be the parent.
			Camera camera = GetComponentInChildren<Camera>();
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed ;

		}
	
	}
}
