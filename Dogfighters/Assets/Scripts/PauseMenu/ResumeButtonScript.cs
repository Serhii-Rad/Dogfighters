using UnityEngine;
using UnityEngine.UI;

public class ResumeButtonScript : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClickResume);
    }

    private void OnClickResume()
    {
        Time.timeScale = 1;
        _pausePanel.SetActive(false);
    }
}
