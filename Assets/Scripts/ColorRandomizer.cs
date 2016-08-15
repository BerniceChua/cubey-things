using UnityEngine;
using System.Collections;

public class ColorRandomizer : MonoBehaviour {
	void Start() {
		Color randomColor = new Color (Random.value, Random.value, Random.value, Random.value);
		GetComponent<Renderer>().material.color = randomColor;
	}
}