using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;
    private bool _paused = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !_paused)
        {
            Time.timeScale = 0;
            _pausePanel.SetActive(!_paused);
            _paused = !_paused;
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && _paused)
        {
            Time.timeScale = 1;
            _pausePanel.SetActive(!_paused);
            _paused = !_paused;
        }
    }
}
