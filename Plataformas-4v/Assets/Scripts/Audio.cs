using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public Slider sl;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AudioManeger.Instance.volume = sl.value;

    }
}
