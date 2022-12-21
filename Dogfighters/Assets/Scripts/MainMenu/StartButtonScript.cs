using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour
{
    private int _gameStartScene = 1;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(StartGame);
    }

    private void StartGame() => SceneManager.LoadScene(_gameStartScene);
}
