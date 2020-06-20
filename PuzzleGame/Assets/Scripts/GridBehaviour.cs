using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehaviour : MonoBehaviour
{
    public int rows = 10,
               columns = 10,
               scale = 1;

    public GameObject gridPrefab;
    public Vector3 leftBottomLocation = new Vector3(0, 0, 0);

    public GameObject[,] gridArray;
    public int startX = 0;
    public int startY = 0;
    public int endX = 2;
    public int endY = 2;
  

    
    void Awake()
    {
        gridArray = new GameObject[columns, rows]; //iniate array

        if (gridPrefab)
            GenerateGrid();
        else print("missing gridprefab, please assign");
              
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
     * Instantiates GameObject, creates Grid
     */
    void GenerateGrid()
    {
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {                                   
                GameObject obj = Instantiate(gridPrefab, new Vector3(leftBottomLocation.x + scale * i, leftBottomLocation.y + scale * j, leftBottomLocation.z + scale * j), Quaternion.identity);
                obj.transform.SetParent(gameObject.transform); // current gameobject that instantiated the grid
                obj.GetComponent<GridStats>().x = i;
                obj.GetComponent<GridStats>().y = j;

                gridArray[i, j] = obj;  //instantiate and add to the grid

            }
        }
    }

    /*
     * sets up Grid
     * everything is -1 except for where we start which is 0
     */
    void InitialSetup ()
    {
        foreach (GameObject obj in gridArray)
        {
            obj.GetComponent<GridStats>().visited = -1;

        }
        gridArray[startX, startY].GetComponent<GridStats>().visited = 0;
    }

    /*
     * int direction tells us which case to use 
     * 1 is up      rows    y +1    cause 0,0 is botten left
     * 2 is right   columns x +1
     * 3 is down    -1      y -1
     * 4 is left    -1      x -1
     */
    bool TestDirection (int x, int y, int step, int direction)
    {
        switch(direction)
        {
            case 1:
                if (x + 1 < rows && gridArray [x, y + 1] && gridArray[x, y + 1].GetComponent<GridStats>().visited == step)
                    return true;
                else
                    return false; 
            
            case 2:
                if (x + 1 < columns && gridArray[x + 1, y ] && gridArray[x + 1, y].GetComponent<GridStats>().visited == step)
                    return true;
                else
                    return false; 
            
            case 3:
                if (y - 1 < -1 && gridArray[x, y - 1] && gridArray[x, y - 1].GetComponent<GridStats>().visited == step)
                    return true;
                else
                    return false; 
            
            case 4:
                if (x - 1 >-1  && gridArray[ x- 1, y] && gridArray[x - 1, y].GetComponent<GridStats>().visited == step)
                    return true;
                else
                    return false;
        }

        return false;

    }
     /*
      * set different visited coordinates to the 
      */
    void SetVisited (int x, int y, int step)
    {
        if (gridArray[x, y])
            gridArray[x, y].GetComponent<GridStats>().visited = step;

    }
}
