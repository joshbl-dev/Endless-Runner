using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseButton : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
    }

    public void OnButton() {
        Debug.Log("Button was pressed!");
        Application.Quit();
    }
}