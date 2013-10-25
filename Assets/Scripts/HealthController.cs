using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {
	
	public int health = 10;

	void ApplyDamage(int damage)
	{
		if (health > 0) {
			health -= damage;
			if (health < 0)
			{
				health = 0;
			}
			if (health == 0)
			{
				Destroy(gameObject);
			}
			StartCoroutine("DamageEffect");
		}
	}
	
	IEnumerator DamageEffect()
	{
		renderer.material.color = new Color(255,50,50);
		yield return new WaitForSeconds(.1f);
		renderer.material.color = Color.white;
	}
}
