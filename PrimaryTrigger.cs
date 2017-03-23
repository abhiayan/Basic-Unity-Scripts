using UnityEngine;
using System.Collections;

public class PrimaryTrigger : MonoBehaviour {
	
	void OnTriggerEnter(Collider collider)
	{
		print ("abc");
		SecondaryTrigger trigger = GetComponentInChildren<SecondaryTrigger>();
		trigger.ExpectCollider(collider);
	}
}

