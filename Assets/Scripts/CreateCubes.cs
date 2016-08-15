using UnityEngine;
using System.Collections;

public class CreateCubes : MonoBehaviour {

	public GameObject[] randomCubes;
	public Vector3 spawnValues;
	public float spawnDelay;
	public float spawnMaxDelay;
	public float spawnMinDelay;

	public int startWait;
	public bool stop;

	private int randomCube;

	void Start () {
		StartCoroutine (waitSpawner ());
	}
	
	void Update () {
		spawnDelay = Random.Range (spawnMinDelay, spawnMaxDelay);
	}

	IEnumerator waitSpawner() {
		yield return new WaitForSeconds (startWait);

		while (!stop) {
			randomCube = Random.Range (0, 2);

			Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x/2, spawnValues.x/2), 1, Random.Range(-spawnValues.z/2, spawnValues.z/2));

			Instantiate (randomCubes [randomCube], spawnPosition + transform.TransformPoint (0, 0, 0), gameObject.transform.rotation);

			yield return new WaitForSeconds (spawnDelay);
		}
	}
}