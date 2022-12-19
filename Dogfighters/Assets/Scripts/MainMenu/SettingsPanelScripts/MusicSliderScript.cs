using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSliderScript : MonoBehaviour
{
    [SerializeField] private Slider _musicSlider;

    void Start()
    {
    }

    void Update()
    {
        GetComponent<AudioSource>().volume = _musicSlider.value;
    }
}
