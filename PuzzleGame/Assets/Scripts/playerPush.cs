using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPush : MonoBehaviour
{
    public LayerMask mask;      // which layer should the object interact with
    public float distance = 1f;

    GameObject sheep;

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;     // static in physics class
        
        if (Physics.Raycast(ray, out hitInfo, distance, mask))              // grants access to the method, distance parameter 
        {
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);   // ray starting point, hitInfo end point
        } else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * distance, Color.green);  

        }


        if (hitInfo.collider != null && Input.GetKeyDown(KeyCode.E)) // check if we hit something
        {
            sheep = hitInfo.collider.gameObject;
        }
           
    }
}
