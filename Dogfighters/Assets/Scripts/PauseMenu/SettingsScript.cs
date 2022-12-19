using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnSettingsClick);
    }

    private void OnSettingsClick() => _settingsPanel.SetActive(true);
}
