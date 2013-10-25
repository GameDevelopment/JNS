using UnityEngine;
using System.Collections;

public class ParallaxScrolling : MonoBehaviour {
	
	public float offset = 1;
	
	private float startX;
	private float cameraX;

	// Use this for initialization
	void Start () {
		startX = transform.position.x;
		cameraX = Camera.main.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x = (Camera.main.transform.position.x - cameraX) / offset + startX;
		transform.position = pos;
	}
}
