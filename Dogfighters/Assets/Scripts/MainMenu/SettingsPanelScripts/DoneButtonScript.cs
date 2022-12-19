using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoneButtonScript : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(CloseSettingsPanel);
    }

    private void CloseSettingsPanel() => _settingsPanel.SetActive(false);
}
