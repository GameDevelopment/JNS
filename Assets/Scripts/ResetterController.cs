using UnityEngine;
using System.Collections;

public class ResetterController : MonoBehaviour {
	
	public Vector3 rotation;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotation * Time.deltaTime);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			StartCoroutine("Respawn");
			other.GetComponent<PlayerController>().ResetJump();
		}
	}
	
	IEnumerator Respawn()
	{
		renderer.enabled = false;
		collider.enabled = false;
		yield return new WaitForSeconds(2);
		renderer.enabled = true;
		collider.enabled = true;
	}
}
