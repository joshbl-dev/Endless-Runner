using System.Collections;
using UnityEngine;

public class FloorSpawner : MonoBehaviour {
    public GameObject[] prefabs;

    private bool initialSpawn = true;
    
    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnFloor());
    }

    IEnumerator SpawnFloor() {
        while (true) {
            if (initialSpawn) {
                Instantiate(prefabs[0], new Vector3(-28f, -1.5f, 3f),
                    Quaternion.Euler(0f, 0f, 0f));
                Instantiate(prefabs[0], new Vector3(-58f, -1.5f, 3f),
                    Quaternion.Euler(0f, 0f, 0f));
                initialSpawn = false;
            }
            else
                Instantiate(prefabs[0], new Vector3(-58f, -1.5f, 3f),
                    Quaternion.Euler(0f, 0f, 0f));
            yield return new WaitForSeconds(5);
        }
    }
}