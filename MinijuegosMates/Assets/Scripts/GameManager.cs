using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public List<int>        elements;
    public int              randomNum, randomElement;

    public bool             easyMode, mediumMode, hardMode = false;

    public GameObject       algoritmoLineal, algoritmoBinario, algoritmoTernario;
    public GameObject       gameCard, randomNumCard, cardCanvas;
    public GameObject       gameMode;


    // Start is called before the first frame update
    void Start()
    {

        // ----- GENERATE LIST -----

        GetElementList();
        GetElement();
        
        // ----- SET ALGORITHM ----- 

        if ( easyMode == true )
        {
            SetEasyMode();
        }
        else if ( mediumMode == true )
        {
            SetMediumMode();
        }
        else if ( hardMode == true )
        {
             SetHardMode();
        }

        Destroy( gameMode );

        // -----   -----


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ////////////////////////////////////////////////////////////////////////////////
    
    // ------------ LISTA DE NÚMEROS -------------

    void GetElementList()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            elements[i] = Random.Range(0, 100);
            Instantiate( gameCard, Vector3.zero, Quaternion.identity, cardCanvas.transform );
            gameCard.GetComponent<CardScript>().cardNumber = elements[i];
        }

        elements.Sort();

    }

    void GetElement()
    {
        randomElement = Random.Range(0, 9);
        randomNum = elements[randomElement];

        randomNumCard.GetComponent<RNCardScript>().numRandom = randomNum;
    }

    ////////////////////////////////////////////////////////////////////////////////
    
    // ---------- DIFFICULTY MODES ------------

    public void SetEasyMode()
    {
       algoritmoLineal.SetActive(true);
    }

    public void SetMediumMode()
    {
        algoritmoBinario.SetActive(true);
    }

    public void SetHardMode()
    {
        algoritmoTernario.SetActive(true);
    }
}
