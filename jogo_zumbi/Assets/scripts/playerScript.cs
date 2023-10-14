using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public gunScript gun;

    private float movementX;
    private float movementZ;
    private float rot;


    
    void Start()
    {
       
    }

    
    void Update()
    {
        Move();
        
        atirar();
        
    }

   


    private void Move()
    {
        movementX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; 
        movementZ = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(movementX, 0, movementZ);

    }

   

    private void atirar()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gun.spawnBullet();
        }
    }

   
}
