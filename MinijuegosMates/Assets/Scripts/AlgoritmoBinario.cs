using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgoritmoBinario : MonoBehaviour
{

    public List<int>    elements;
    public int          randomNum, randomElement, numMax, numMin;
    public GameObject   carta;

    // Start is called before the first frame update
    void Start()
    {       
        GetElementList();
        GetElement();


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

        numMin              = elements[0];
        numMax              = elements[9];
    }

    void GetElement()
    {
        randomElement       = Random.Range(0, 9);
        randomNum           = elements[randomElement];
    }

    void FindElement()
    {

    }

    public void SetMediumMode()
    {
        gameObject.SetActive(true);
    }
}
