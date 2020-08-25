using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiOnMatte : MonoBehaviour
{
    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    public int sushiSprite = 0;

    public int currentSushi = -1;

    public GameObject z1, z1_check, z2, z2_check, z3, z3_check;

    void Update()
    {
        switch (currentSushi)
        {
            case 0:
                spriteRenderer.sprite = spriteArray[0];
                z1.SetActive(false);
                z1_check.SetActive(true);
                break;

            case 1:
                spriteRenderer.sprite = spriteArray[1];
                z2.SetActive(false);
                z2_check.SetActive(true);
                break;

            case 2:
                spriteRenderer.sprite = spriteArray[2];
                z3.SetActive(false);
                z3_check.SetActive(true);
                break;

            default:
                break;

        }

    }

    // Update is called once per frame
    /**
    void TestSushi(Sushi sushi)
    {
        switch (sushi.sushiCount) { 

        case 0:
            // can be placed on mat
            spriteRenderer.sprite = spriteArray[0];
            break;

        case 1:
            if position != alge
                break;
            spriteRenderer.sprite = spriteArray[1];
            break;

        case 2:
            if position != reis
                break;
            spriteRenderer.sprite = spriteArray[2];
            break;

        }
    */
    }
