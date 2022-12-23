using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TryOneMoreTimeButton : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnTryOneMoreTimeClick);
    }

    private void OnTryOneMoreTimeClick() => GameControl.StartGame();
}
