using UnityEngine;
using System.Collections;

public class DestroyThisRandomCube : MonoBehaviour {
	public float delayUntilDestroy = 3.0f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, delayUntilDestroy);
	}
}