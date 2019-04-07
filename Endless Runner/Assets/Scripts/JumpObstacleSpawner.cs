using System.Collections;
using UnityEngine;

public class JumpObstacleSpawner : MonoBehaviour {
    public GameObject[] prefabs;

    private float[] spawnPointsZ = {-2.9f, -.9f, 1.1f};
    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnnObstacle());
    }

    IEnumerator SpawnnObstacle() {
        while (true) {
                Instantiate(prefabs[0], new Vector3(-28f, -.5f, spawnPointsZ[Random.Range(0, 2)]),
                    Quaternion.Euler(0f, 90f, 0f));
            yield return new WaitForSeconds(Random.Range(3, 10));
        }
    }
}