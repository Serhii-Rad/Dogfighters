using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OpenMainMenu);
    }

    private void OpenMainMenu() => SceneManager.LoadScene(Scenes.MainMenuScene.ToString());
}
