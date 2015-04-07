using UnityEngine;
using System.Collections;

public class Demo : MonoBehaviour
{
	public int health;

	void Update ()
	{
		DemagePlayer (1);

		if (health <= 0) {
			//health = 0;
			Destroy (gmeObject);
			Debug.Log ("Player dead! Health: " + health);
		}
	}

	public void DemagePlayer (int demage)
	{
		health -= demage;
	}
}
