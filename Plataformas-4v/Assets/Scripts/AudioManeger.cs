using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class AudioManeger : MonoBehaviour
{
    [SerializeField] private  float volume = 1f;
    public static AudioManeger Instance;
    public float vol;
    
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void OnEnable()
    {
        AudioObserverManager.OnVolumeChanged += ProcessVolumeChanged;

    }

    private void ProcessVolumeChanged(float value)
    {
        volume = value;
    }

    private void OnDisable()
    {
        AudioObserverManager.OnVolumeChanged -= ProcessVolumeChanged;
        
    }


    void Update()
    {
        
    }
}
