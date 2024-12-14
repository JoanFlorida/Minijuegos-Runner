using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardScript : MonoBehaviour
{

    public bool         isActive;
    public GameObject   GameManager;
    public string       cardNumString;
    public int          cardNumber;
    public TMP_Text     cardNumText;


    // Start is called before the first frame update
    void Start()
    {
        cardNumString = cardNumber.ToString();
        cardNumText.SetText( cardNumString );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
