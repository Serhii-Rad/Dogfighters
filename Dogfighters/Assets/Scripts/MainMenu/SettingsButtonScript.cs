using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsButtonScript : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OpenSettingsPanel);
    }

    private void OpenSettingsPanel() => _settingsPanel.SetActive(true);
}
