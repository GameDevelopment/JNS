using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	
	public Transform target;
	public float minHeight;
	public float maxHeight;
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPosition = target.position;
		targetPosition.y = Mathf.Max (Mathf.Min (maxHeight, targetPosition.y), minHeight);
		transform.position = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
	}
}
