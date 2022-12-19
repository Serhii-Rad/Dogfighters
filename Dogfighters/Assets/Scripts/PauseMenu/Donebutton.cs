using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Donebutton : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnDoneClick);
    }

    private void OnDoneClick() => _settingsPanel.SetActive(false);
}
