using UnityEngine;
using System.Collections;

public class OtherDemo : MonoBehaviour
{
	public GameObject player;
	private Demo playerScript;

	public int[] numbers;

	// Use this for initialization
	void Start ()
	{
		playerScript = player.GetComponent<Demo> ();
		playerScript.DemagePlayer (10000);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (playerScript.health <= 0) {
			print ("Other demo detected player is dead!");
		}
	}
}
