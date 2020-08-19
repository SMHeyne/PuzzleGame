using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool m_ReadyForInput; //is false
    public Player m_Player;



    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //read input
        moveInput.Normalize();  // magnitude of 1

     

        /*is >0.5 when key is pressed
         * is 0 when not pressed
         * in the beginning is 0 --> else block
         * now is ready for input
         * 
         * pressed --> 2. if block --> ready is false
         */
        if (moveInput.sqrMagnitude > 0.5)
        {  // valid input, only process key once eve when hold down, each movement input must be discrete
            if (m_ReadyForInput)
            {

                m_ReadyForInput = false;
                m_Player.Move(moveInput);
                //m_NextButtion.SetActive(IsLevelComplete());
            }
            


        }
        else         
                m_ReadyForInput = true;
    }


}
