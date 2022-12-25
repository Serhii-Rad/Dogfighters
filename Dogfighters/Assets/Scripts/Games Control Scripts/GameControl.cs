using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private GameObject _lastEnemy;

    private bool _paused = false;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_paused)
        {
            PauseGame();
            _pausePanel.SetActive(!_paused);
            _paused = !_paused;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _paused)
        {
            UnPauseGame();
            _pausePanel.SetActive(!_paused);
            _paused = !_paused;
        }
        LevelFinish();
    }
    public static void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Scenes.SampleScene.ToString());
        AudioManager.Instance.PlayMusic(Music_Type.FightingTheme);
    }

    public static void PauseGame() => Time.timeScale = 0;

    public static void UnPauseGame() => Time.timeScale = 1;

    public void LevelFinish()
    {
        if (_lastEnemy.IsDestroyed())
        {
            _winScreen.SetActive(true);
            PauseGame();
        }
    }
}

public enum Scenes
{
    MainMenuScene, SampleScene 
}

