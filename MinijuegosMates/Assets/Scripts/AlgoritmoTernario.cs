using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgoritmoTernario : MonoBehaviour
{
    public List<int>            elements;
    public int                  randomNum, posRandomElement, limMax, limMin, marcMax, marcMin;

    // Start is called before the first frame update
    void Start()
    {
        GetElementList();
        GetElement();
        FindElement( limMin, limMax, randomNum );
    }

    void GetElementList()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            elements[i] =       Random.Range(0, 100);
        }

        elements.Sort();
        
        limMin =                elements[0];
        limMax =                elements[9];

        marcMin =               0;
        marcMax =               9;
    }

    void GetElement()
    {
        posRandomElement =      Random.Range(0, 9);
        randomNum =             elements[posRandomElement];
    }

    int FindElement( int limMin, int limMax, int randomNum)
    {
        if( limMin < limMax )
        {
            marcMin = limMin + ( limMax - limMin ) / 3;
            marcMax = limMax - ( limMax - limMin ) / 3;

            if ( marcMin == randomNum )
            {
                Debug.Log( marcMin );
                return marcMin;
            }
            else if ( marcMax == randomNum )
            {
                Debug.Log( marcMax );
                return marcMax;
            }
            else if ( randomNum < marcMin )
            {
                return FindElement( limMin, marcMin - 1, randomNum );
            }
            else if ( randomNum > marcMax )
            {
                return FindElement( marcMax + 1, limMax, randomNum );
            }
            else
            {
                return FindElement( marcMin + 1, marcMax - 1, randomNum );
            }
        } 
        else { Debug.Log("Valor no encontrado."); return 0; };
    }

}
