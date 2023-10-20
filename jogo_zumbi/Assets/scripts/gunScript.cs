using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{

    public Transform gun;
    public int maxDistance;
    public float forceIntensity;
    public GameObject tiro;
    public Transform tiroTransform;


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
                rigOther.AddForceAtPosition(forceIntensity * gun.forward, hitInfo.point, ForceMode.Impulse);
                
           }
      }
      
    }
    

}
