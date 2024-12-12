using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlgoritmoLineal : MonoBehaviour
{

    public List<int>        elements;
    public int              randomNum, randomElement;

    // Start is called before the first frame update
    void Start()
    {
        GetElementList();
        GetElement();
        FindElement();
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
        randomElement       = Random.Range(0, 9);
        randomNum           = elements[randomElement];
    }

    int FindElement()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            if (elements[i] == randomNum)
            {
                Debug.Log("Se encontró el número. Es " + randomNum);
                return randomNum;
            }
        }

        Debug.Log("No se encontró el número.");
        return 0;
    }

    public void SetEasyMode()
    {
       gameObject.SetActive(true);
    }
}
