using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject enemy;

    
   
    void Start()
    {
        StartCoroutine(spawnar());
    }

    
    void Update()
    {
        
    }

    IEnumerator spawnar()
    {
        yield return new WaitForSeconds(7);
        Instantiate(enemy);
        StartCoroutine(spawnar());
    }
   
}
