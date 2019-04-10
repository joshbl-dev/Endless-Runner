using UnityEngine;


public class BarrierType : MonoBehaviour {

    private GameObject player = FloorSpawner.player;
    
    // Update is called once per frame
    void Update() {
        if (player) 
            if (transform.position.x > player.transform.position.x + 10)
                Destroy(gameObject);
    }
}