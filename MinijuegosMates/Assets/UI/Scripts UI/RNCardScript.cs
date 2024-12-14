using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RNCardScript : MonoBehaviour
{
    public GameObject       gameManager;
    public string           cardNumString;
    public int              numRandom;
    public TMP_Text         cardNumText;


    // Start is called before the first frame update
    void Start()
    {
        cardNumString =     numRandom.ToString();
        cardNumText.SetText(cardNumString);
    }

}
