using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashManeger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoudMainMenu",2f);
        
    }

    private void LoudMainMenu()
    {
        GameManager.Instance.LoudMainMenu();
    }
}
