using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player; //Public variable to store a reference to the player game object

    // Use this for initialization
    void Start() {
        transform.position = new Vector3(player.transform.position.x + 6, player.transform.position.y + 2.75f, 0);
    }

    // LateUpdate is called after Update each frame
    void LateUpdate() {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = new Vector3(player.transform.position.x + 6, transform.position.y, 0);
        //transform.Translate(Player.speedX * Time.deltaTime,0, 0);
    }
}