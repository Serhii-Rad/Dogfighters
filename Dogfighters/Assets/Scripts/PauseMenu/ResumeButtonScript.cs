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
        GameControl.UnPauseGame();
        _pausePanel.SetActive(false);
    }
}
