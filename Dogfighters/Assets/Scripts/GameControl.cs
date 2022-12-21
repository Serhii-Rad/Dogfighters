using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;
    private bool _paused = false;
    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = GameObject.FindGameObjectWithTag("MainCamera").GetComponentInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_paused)
        {
            _audioSource.Pause();
            Time.timeScale = 0;
            _pausePanel.SetActive(!_paused);
            _paused = !_paused;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _paused)
        {
            _audioSource.UnPause();
            Time.timeScale = 1;
            _pausePanel.SetActive(!_paused);
            _paused = !_paused;
        }
    }
}
