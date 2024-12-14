using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{

    public bool         setEasyMode, setMediumMode, setHardMode = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (setEasyMode == true )
        {
            GetComponent<GameManager>().easyMode =      true;
        }
        if (setMediumMode == true)
        {
            GetComponent<GameManager>().mediumMode =    true;
        }
        if (setHardMode == true)
        {
            GetComponent<GameManager>().hardMode =      true;
        }
    }

}
