using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public Transform player;
    public float speed;
    public playerScript Player;

    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
       
        
    }

    
    void Update()
    {
       
        Vector3 direcao = player.position - transform.position;
        direcao.Normalize(); 

        
        transform.position += direcao * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player.vida--;
        }
    }
}
