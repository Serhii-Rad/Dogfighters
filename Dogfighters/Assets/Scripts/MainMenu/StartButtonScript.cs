using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(GameControl.StartGame);
    }
}
