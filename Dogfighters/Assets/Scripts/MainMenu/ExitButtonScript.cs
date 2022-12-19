using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButtonScript : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(CloseApp);
    }

    private void CloseApp() => Application.Quit();
}
