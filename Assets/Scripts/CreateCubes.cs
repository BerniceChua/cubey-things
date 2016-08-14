using UnityEngine;
using System.Collections;

using Random = System.Random;

public class CreateCubes : MonoBehaviour {

	private Random random = new Random ();
	private GameObject randomCube = (GameObject)Instantiate(Resources.Load("RandomCube"));

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 5; i++) {
			Instantiate(randomCube);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}