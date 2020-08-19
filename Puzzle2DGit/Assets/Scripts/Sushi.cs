using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Sushi : MonoBehaviour
{
    public bool m_OnMat;
    public int sushiCount = 0;

    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;

    public bool Move(Vector2 direction)
    {
        if (SushiBlocked(transform.position, direction))
            return false;
        else
        {
            transform.Translate(direction);     //Box not blocked so move it
            TestForOnMat();
            return true;
        }
    }

    bool SushiBlocked(Vector3 position, Vector2 direction)
    {
        Vector2 newPos = new Vector2(position.x, position.y) + direction;           //new position we want to move to

        Tilemap wallmap = GameObject.FindGameObjectWithTag("Wall").GetComponent<Tilemap>(); // get me my wall tilemap
        TileBase newTile = wallmap.GetTile(new Vector3Int((int)newPos.x, (int)newPos.y, 0)); // get me the tile at newPos

        if (newTile != null) // is there a wall tile? (actually: is there any tile?)
        {
            return true; // yup. must be wall, so definitely blocked
        }

        GameObject[] sushis = GameObject.FindGameObjectsWithTag("Sushi");       // sushi blocks sushi

        foreach (var sushi in sushis)
        {
            if (sushi.transform.position.x == newPos.x && sushi.transform.position.y == newPos.y)
            {
                Sushi su = sushi.GetComponent<Sushi>();
                if (su)
                    return true;

                else return false;
            }
        }

        GameObject mat = GameObject.FindGameObjectWithTag("Matte");

        if (newPos.x == mat.transform.position.x && newPos.y == mat.transform.position.y)
        {
            if (sushiCount != mat.GetComponent<SushiOnMatte>().currentSushi + 1)
            {
                return true;
            }
        }

        return false;
    }

    void TestForOnMat() // call SushiOnMatte here? and then delete object or lock it from moving? and Suhsi on Matte will replace sprites
    {
        GameObject mat = GameObject.FindGameObjectWithTag("Matte");
        GameObject sheep = GameObject.FindGameObjectWithTag("Sheep");

        if (transform.position.x == mat.transform.position.x && transform.position.y == mat.transform.position.y)
        {

            m_OnMat = true;
            mat.GetComponent<SushiOnMatte>().currentSushi = sushiCount;
            Destroy(this.gameObject);
            
            if (mat.GetComponent<SushiOnMatte>().currentSushi == 2)
            {

                mat.GetComponent<EndScreen>().callEnd();
                Destroy(sheep);
            }
            
            return;
        }
        
        GetComponent<SpriteRenderer>().color = Color.white; //return to normal
        m_OnMat = false;

        

        /**
         *       
        foreach (var mat in mats)
        {
            if (transform.position.x == mat.transform.position.x && transform.position.y == mat.transform.position.y)
            {
                GetComponent<SpriteRenderer>().color = Color.red; //or laters different sprite
                m_OnMat = true;
                return;
            
        
        switch (sushiCount)
        {
                    
        case 0:
            // can be placed on mat
            spriteRenderer.sprite = spriteArray[0];
            break;

        case 1:
            test if sushi beneath is case 0
        
        case 2:
            if position != reis
                break;
            spriteRenderer.sprite = spriteArray[2];
            break;


        }
        }
        */
    }
}
