using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float rotSpeed;
    public gunScript gun;
    public int vida;
    public diretorSctipt diretor;
    public float bulletMax;
    

    private float movementX;
    private float movementZ;
    private float rot;
    private Rigidbody rig;
    private bool isgrounded;


    
    void Start()
    {
       rig = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Move();
        Atirar();
        Morrer();
        Run();
        Jump();
        
    }

   


    private void Move()
    {
        movementX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; 
        movementZ = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(movementX, 0, movementZ);

    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && isgrounded)
        {
            rig.velocity = new Vector3 (0, jumpForce, 0);
        }
    }

   

    private void Atirar()
    {
        if (Input.GetButtonDown("Fire1") && bulletMax > 0)
        {
            
            gun.shootRaycast();
            bulletMax--;
        }
    }
    
    private void Morrer()
    {
        if(vida <= 0)
        {
            diretor.GameOver();
            
        }
    }

    private void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "chao")
        {
            isgrounded = true;
        }
    }

}
