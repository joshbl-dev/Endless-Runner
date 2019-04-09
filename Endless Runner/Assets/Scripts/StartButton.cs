using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {
    
    public void OnButton() {
        Debug.Log("Button was pressed!");
        SceneManager.LoadScene("Game");
    }
}