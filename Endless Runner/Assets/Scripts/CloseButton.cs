using UnityEngine;

public class CloseButton : MonoBehaviour {

    public void OnButton() {
        Debug.Log("Button was pressed!");
        Application.Quit();
    }
}