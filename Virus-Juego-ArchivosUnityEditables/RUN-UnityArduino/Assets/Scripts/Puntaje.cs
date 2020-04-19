using UnityEngine;
using System.Collections;

public class Puntaje : MonoBehaviour
{

	public int value = 33;
	public GameObject explosionPrefab;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (GameManager.gm != null)
			{
				// tell the game manager to Collect
				GameManager.gm.Collect(value);
			}

			// explode if specified
			if (explosionPrefab != null)
			{
				Instantiate(explosionPrefab, transform.position, Quaternion.identity);
			}

			// destroy after collection
			Destroy(gameObject);
		}

		if (other.gameObject.tag == "Finish")
		{

			// destroy after collection
			Destroy(gameObject);
		}
	}


}