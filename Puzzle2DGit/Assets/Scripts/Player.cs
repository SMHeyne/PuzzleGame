using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    public bool Move(Vector2 direction)
    {
        if (Mathf.Abs(direction.x) < 0.5) //will set one of the coords to 0, always --> avoid diagonal movements
            direction.x = 0;
        else
            direction.y = 0;

        direction.Normalize(); //makes either x or y = 1, guarantee one unit movement at a time, only one tile

        if (Blocked(transform.position, direction))
        {
            return false;
        } else
        {
            transform.Translate(direction);
            return true;
        }
    }

    bool Blocked(Vector3 position, Vector2 direction)
    {
        Vector2 newPos = new Vector2(position.x, position.y) + direction;           //new position we want to move to

        Tilemap wallmap = GameObject.FindGameObjectWithTag("Wall").GetComponent<Tilemap>(); // get me my wall tilemap
        TileBase newTile = wallmap.GetTile(new Vector3Int((int)newPos.x, (int)newPos.y, 0)); // get me the tile at newPos

        if(newTile != null) // is there a wall tile? (actually: is there any tile?)
        {
            return true; // yup. must be wall, so definitely blocked
        }


        GameObject[] sushis = GameObject.FindGameObjectsWithTag("Sushi");       // same thing with sushi components, everything tagged with sushi

        foreach (var sushi in sushis)
        {
            if (sushi.transform.position.x == newPos.x && sushi.transform.position.y == newPos.y)
            {
                Sushi su = sushi.GetComponent<Sushi>();

                if (su && su.Move(direction))
                {
                    return false;
                }
                else return true;
            }
        }

        GameObject mat = GameObject.FindGameObjectWithTag("Matte");

        if (newPos.x == mat.transform.position.x && newPos.y == mat.transform.position.y)
        {
            if (mat.GetComponent<SushiOnMatte>().currentSushi > -1)
            {
                return true;
            }
        }

        return false;
    }
}

