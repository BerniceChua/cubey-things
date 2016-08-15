using UnityEngine;
using System.Collections;

public class SizeRandomizer : MonoBehaviour {
	void Start () {
		float cubeSize = Random.Range(0.001f, 2);
		transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
	}
}
