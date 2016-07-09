using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/// <summary>
/// Projeto para estudo de ADS da propria unity
/// </summary>
public class GameOverBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // chama uma nova scene
    public void OpenScene()
    {
        SceneManager.LoadScene("Main");
    }
}
