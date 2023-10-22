using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public Transform playerT;
    public float speed;
    public playerScript playerS;
    public int vidaInimigo;
    

    

    void Start()
    {
        
       
        
    }

    
    void Update()
    {
       
        Vector3 direcao = playerT.position - transform.position;
        direcao.Normalize(); 

        
        transform.position += direcao * speed * Time.deltaTime;
        
    }

  

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerS.vida--;
        }
    }
}
