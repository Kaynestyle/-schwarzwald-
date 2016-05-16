using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Door : MonoBehaviour {

    public int scene;
    public GameObject loadingScreen;

	void OnTriggerEnter2D()
    {
        print("door triggered");
        loadingScreen.SetActive(true);
        SceneManager.LoadScene(scene);
    }
}
