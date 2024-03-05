using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControler : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;

    private void Start()
    {
        volumeSlider.onValueChanged.AddListener(VolumeSliderChanged);
    }

    private void VolumeSliderChanged(float volume)
    {
        AudioObserverManager.VolumeChanged(volume);
        
    }

    private void Update()
    {
        
    }
}
