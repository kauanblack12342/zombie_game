using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float speed;
    public float rotSpeed;

    private float movementX;
    private float movementZ;
    private float rot;

    
    void Start()
    {
       
    }

    
    void Update()
    {
        Move();
        girar();
        
    }

   


    private void Move()
    {
       
        movementZ = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(movementX, 0, movementZ);

    }

    private void girar()
    {
        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0,rot,0);

    }

   
}
