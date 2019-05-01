using System.Collections;
using UnityEngine;

public class JumpObstacleSpawner : BarrierSpawner {

    private float[] spawnPointsZ = {-2.9f, -.9f, 1.1f};
    // Use this for initialization
    void Start () {
        Debug.Log("Starting jump spawns");
        Invoke("LateStart", 0);
    }

    void LateStart() {
        StartCoroutine(SpawnObstacle());
    }

    IEnumerator SpawnObstacle() {
        while (true) {
            var barrier = Instantiate(prefabs[0], new Vector3(((int) player.transform.position.x - 25), -.5f, spawnPointsZ[Random.Range(0, 2)]),
                    Quaternion.Euler(0f, 90f, 0f));
            barrier.hideFlags = HideFlags.HideInHierarchy;
            yield return new WaitForSeconds(Random.Range(1, 3));
        }
    }
}