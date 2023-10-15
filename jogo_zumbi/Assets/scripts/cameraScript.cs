using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Transform head;
    public Transform body;
    public float rotationX;
    public float rotationY;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

   
    void LateUpdate()
    {
        transform.position = head.position;
    }

     void Update()
     {
        float verticalDelta = Input.GetAxis("Mouse Y");
        float horizontalDelta = Input.GetAxis("Mouse X");

        rotationX += horizontalDelta;
        rotationY += verticalDelta;

        body.localEulerAngles = new Vector3(0, rotationX, 0);
        transform.localEulerAngles = new Vector3 (-rotationY,rotationX,0);
     }

    
}
