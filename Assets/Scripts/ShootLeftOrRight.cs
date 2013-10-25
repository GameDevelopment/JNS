using UnityEngine;
using System.Collections;

public class ShootLeftOrRight : MonoBehaviour {
	
	public float force = 20;
	public float spread = 1;
	public GameObject bullet;
	
	public void Shoot(bool right)
	{
		GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
		shot.rigidbody.AddForce(new Vector3(force * (right?1:-1), Random.Range (-spread, spread), 0), ForceMode.VelocityChange);
	}
}
