using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    public GameObject bullet; 


    void Start()
    {
        
    }
    private void Update()
    {
        Physics.Raycast(transform.position, Vector3.forward, 10);
    }

    public void spawnBullet()
    {
        Instantiate(bullet,transform.position,transform.rotation);
        
    }
}
