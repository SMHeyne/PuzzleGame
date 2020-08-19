using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiOnMatte : MonoBehaviour
{
    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    public int sushiSprite = 0;

    public int currentSushi = -1;

    void Update()
    {
        switch (currentSushi)
        {
            case 0:
                spriteRenderer.sprite = spriteArray[0];
                break;

            case 1:
                spriteRenderer.sprite = spriteArray[1];
                break;

            case 2:
                spriteRenderer.sprite = spriteArray[2];
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
