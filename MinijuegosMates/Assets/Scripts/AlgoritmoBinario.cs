using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgoritmoBinario : MonoBehaviour
{

    public List<int>    elements;
    public int          randomNum, posRandomElement, limMax, limMin, numCentral, posNumCentral, posNumMin, posNumMax;


    // Start is called before the first frame update
    void Start()
    {
        GetElementList();
        GetElement();
        // FindElement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetElementList()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            elements[i]     = Random.Range(0, 100);
        }
        
        elements.Sort();
    }

    void GetElement()
    {
        posRandomElement    = Random.Range(0, 9);
        randomNum           = elements[posRandomElement];
    }

    void FindElement()
    {
        limMin = elements[0];
        limMax = elements[9];
        numCentral = elements[posNumCentral];
        posNumMin = 0;
        posNumMax = 9;

        while ( limMin < limMax )
        {
            posNumCentral = posNumMax + posNumMin / 2;

            if ( numCentral < randomNum )
            {
                limMin = posNumCentral + 1;
            }
            if ( numCentral > randomNum )
            {
                limMax = posNumCentral - 1;
            }
            else
            {
                Debug.Log( "Encontrado en posición central.");
            }
        }
        Debug.Log("No se encontró el resultado.");
    }

    /*
    void FindElement()
    {
        
        while ( numMin < numMax )
        {
            posNumCentral = posNumMax + posNumMin / 2;

            if ( numCentral < randomNum )
            {
                posNumMin = posNumCentral + 1;
            } 
            else if ( numCentral > randomNum )
            {
                posNumMax = posNumCentral - 1;
            } 
            else
            {
                Debug.Log("Encontrado, el número es " + numCentral);
            }
            
        }

        Debug.Log("No se encontró el número.");

    }
    */

    public void SetMediumMode()
    {
        gameObject.SetActive(true);
    }
    
}
