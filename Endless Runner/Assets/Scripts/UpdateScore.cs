using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour {


    public Text text;
    private static int score;

    public Player player;
    // Start is called before the first frame update
    void Start() {   
        DontDestroyOnLoad(gameObject);
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        if (SceneManager.GetActiveScene().name == "Game") {
            if (player) {
                score = player.distance;
                text.text = "Score: " + score;
            }
        }

        if (SceneManager.GetActiveScene().name == "GameOver") {
            text = GameObject.Find("/Canvas/Score").GetComponent<Text>();
            text.text = "Score: " + score;
        }

        if (SceneManager.GetActiveScene().name == "GameOver" &&
            (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Return))) {
            SceneManager.LoadScene("Start");
            Destroy(gameObject);
        }
    }
}
