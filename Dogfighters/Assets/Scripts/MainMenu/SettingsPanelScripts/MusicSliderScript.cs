using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicSliderScript : MonoBehaviour
{
    [SerializeField] private AudioSource _source;

    private Slider _slider;

    void Start()
    {
        _slider = GetComponent<Slider>();
    }

    void Update()
    {
        _source.volume = _slider.value;
    }
}
