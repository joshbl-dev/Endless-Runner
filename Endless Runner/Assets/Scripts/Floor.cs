using UnityEngine;


public class Floor : MonoBehaviour {

    public static int speed = 5;
    
    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (transform.position.x > 16) 
            Destroy(gameObject);
        else
            transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}