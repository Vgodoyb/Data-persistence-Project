using UnityEngine;
using System.Collections;

public class Hoop : MonoBehaviour
{
	public ParticleSystem effect;

	void OnTriggerEnter()
	{
		//	add 1 point to the main basketball script
		Basketball.score++;
		Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.85f);
		Instantiate(effect, position, Quaternion.identity);
	}
}
