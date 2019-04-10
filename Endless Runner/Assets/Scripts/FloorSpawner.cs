using System.Collections;
using UnityEngine;

public class FloorSpawner : BarrierSpawner {
    
    // Use this for initialization
    void Start () {
        var barrier = Instantiate(prefabs[0], new Vector3(player.transform.position.x - 100, -1.5f, 3f),
            Quaternion.Euler(0f, 0f, 0f));
        barrier.hideFlags = HideFlags.HideInHierarchy;
        StartCoroutine(SpawnFloor());
    }

    IEnumerator SpawnFloor() {
        while (true) {
                var barrier = Instantiate(prefabs[1], new Vector3((int) player.transform.position.x - 100, -1.5f, 3f),
                    Quaternion.Euler(0f, 0f, 0f));
                barrier.hideFlags = HideFlags.HideInHierarchy;
            yield return new WaitForSeconds(Player.speedX / 100);
        }
    }
}