using UnityEngine;
using System.Collections;

public class ColorRandomizer : MonoBehaviour {

	// Use this for initialization
	void Start() {
		//Create random color
		Color col1 = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
		//Find mesh from game objects
		Mesh mesh1 = GetComponent<MeshFilter>().mesh;
		//Change colors of meshes
		Vector3[] vertices = mesh1.vertices;
		Color[] colors = new Color[vertices.Length];
		for(int i = 0; i < vertices.Length; i++) {
			colors[i] = col1;
		}
		mesh1.colors = colors; //Set new colors of vertices
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}