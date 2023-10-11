using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float speed;

    private float movementX;
    private float movementZ;
    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
        
    }

   


    private void Move()
    {
        movementX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        movementZ = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(movementX, 0, movementZ);

    }

   
}
