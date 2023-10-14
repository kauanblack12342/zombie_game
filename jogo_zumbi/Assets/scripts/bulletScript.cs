using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float speed;

    private Rigidbody rig;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        rig.velocity = new Vector3(speed,0,0);
        Destroy(gameObject, 3);
    }
}
