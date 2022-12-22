using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public enum SFX_Type
{
    Shoot, Hit, Click, Destroy
}

public enum Music_Type
{
    MainTheme, FightingTheme, BossTheme
}

public class AudioManager : MonoBehaviour
{
    [SerializeField] private List<SfxData> _sfxDataList = new List<SfxData>();
    [SerializeField] private List<MusicData> _musicDataList = new List<MusicData>();

    [SerializeField] private AudioSource _sfxSource;
    [SerializeField] private AudioSource _musicSource;

    public static AudioManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        PlayMusic(Music_Type.MainTheme);
    }

    void Update()
    {
    }

    public void PlaySFX(SFX_Type sfx_Type) { _sfxSource.PlayOneShot(_sfxDataList.Find(x => x.SFX_Type.Equals(sfx_Type)).AudioClip); }

    public void PlayMusic(Music_Type music_Type)
    {
        _musicSource.clip = _musicDataList.Find(x => x.Music_Type.Equals(music_Type)).AudioClip;
        _musicSource.Play();
    }
}

[Serializable]
public class SfxData
{
    [SerializeField] private SFX_Type _sfxType;
    [SerializeField] private AudioClip _audioClip;

    public SFX_Type SFX_Type => _sfxType;
    public AudioClip AudioClip => _audioClip;
}

[Serializable]
public class MusicData
{
    [SerializeField] private Music_Type _musicType;
    [SerializeField] private AudioClip _audioClip;

    public Music_Type Music_Type => _musicType;
    public AudioClip AudioClip => _audioClip;
}

