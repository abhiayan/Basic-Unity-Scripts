using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mouseX = Input.GetAxis ("Mouse X");
		float mouseY = Input.GetAxis ("Mouse Y");
		transform.localRotation = transform.localRotation * Quaternion.Euler (0, mouseX*10f, 0);
		Camera camera = GetComponentInChildren<Camera>();
		camera.transform.localRotation = camera.transform.localRotation * Quaternion.Euler (-mouseY* 10f, 0, 0) ; 
	
	}
}
