using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		//Debug.Log ("Hit: " + other);
		if (other.gameObject.tag == "Enemy") {
			Debug.Log ("Called: ApplyDamage()");
			other.SendMessage ("ApplyDamage", 1, SendMessageOptions.DontRequireReceiver);
		}
		Destroy(gameObject);
	}
	
	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
