using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour
{
    [SerializeField] private int _gameStartScene = 0;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(StartGame);
    }

    private void StartGame() => SceneManager.LoadScene(_gameStartScene);
}
