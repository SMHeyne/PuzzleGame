using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{

    [SerializeField]
    float moveSpeed = 0.25f;

    /*
    [SerializeField]
    float snapDistance = 0.25f;
    */

    Vector3 targetPosition;
    Vector3 startPosition;

    bool moving;    // check if we made to the target position




    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetButtonDown ("Fire1"))
        {
            transform.position += Vector3.forward; // move one unit forward
            moving = true;
        }
       
        // move to the target position & check if we are close to target position
        if (Vector3.Distance(transform.position, targetPosition) > snapDistance && moving) // really close so move!
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        } else {
            transform.position = targetPosition;    // set moving back to false after moving
            moving = false;
        }

    */
        if (moving)
        {


            if (Vector3.Distance(startPosition, transform.position) > 1f)
            {
                transform.position = targetPosition;
                moving = false;     // set moving back to false after moving
                return;
            }
            transform.position += (targetPosition - startPosition) * moveSpeed * Time.deltaTime;
            return;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            targetPosition = transform.position + Vector3.forward;
            startPosition = transform.position;
            moving = true;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            targetPosition = transform.position + Vector3.back;
            startPosition = transform.position;
            moving = true;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            targetPosition = transform.position + Vector3.left;
            startPosition = transform.position;
            moving = true; moving = true;

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            targetPosition = transform.position + Vector3.right;
            startPosition = transform.position;
            moving = true;
        }
    }

}
