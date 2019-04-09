using UnityEngine;


public class Floor : MonoBehaviour {

    public static int speed = 10;
    
    // Update is called once per frame
    void Update() {
        if (transform.position.x > 16) 
            Destroy(gameObject);
        else
            transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}