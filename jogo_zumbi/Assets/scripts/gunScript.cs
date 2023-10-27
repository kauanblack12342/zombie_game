using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{

    public Transform gun;
    public int maxDistance;
    public GameObject tiro;
    public Transform tiroTransform;
    public enemyScript enemy;
    public GameObject enemyGO;
    
   


    void Start()
    {
        
    }
    private void Update()
    {
       
    }

    public void shootRaycast()
    {
        RaycastHit hitInfo;
        
      if( Physics.Raycast(gun.transform.position,gun.forward,out hitInfo, maxDistance))
           {
            Rigidbody rigOther = hitInfo.collider.GetComponent<Rigidbody>();

      if(rigOther == null)
           {
               Instantiate(tiro,hitInfo.point,tiroTransform.transform.rotation); 
               
           }
      else
           {
                enemy.vidaInimigo--;
                if(enemy.vidaInimigo == 0)
                {
                    Destroy(enemyGO);
                }
                
                
                
           }
      }
      
    }
    

}
