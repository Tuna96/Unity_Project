using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    public void LevelLoad (string name) {
        Debug.Log("New level loaded: " + name);
        Application.LoadLevel (name);
    }

    public void QuitRequest ()
    {
        Debug.Log("Quit Requested");
        Application.Quit();
    }
}
