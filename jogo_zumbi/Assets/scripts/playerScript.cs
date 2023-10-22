using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public gunScript gun;
    public int vida;
    public diretorSctipt diretor;
    

    private float movementX;
    private float movementZ;
    private float rot;


    
    void Start()
    {
       
    }

    
    void Update()
    {
        Move();
        
        Atirar();

        Morrer();
        
    }

   


    private void Move()
    {
        movementX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; 
        movementZ = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(movementX, 0, movementZ);

    }

   

    private void Atirar()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            gun.shootRaycast();
        }
    }
    
    private void Morrer()
    {
        if(vida <= 0)
        {
            diretor.GameOver();
            
        }
    }
   
    
   
}
