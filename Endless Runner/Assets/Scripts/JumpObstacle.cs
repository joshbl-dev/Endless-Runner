using UnityEngine;
public class JumpObstacle : MonoBehaviour {
    // Start is called before the first frame update

    private float speed = Floor.speed;
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (transform.position.x > 16) 
            Destroy(gameObject);
        else
            transform.Translate(0, 0, speed * Time.deltaTime);
    }

}