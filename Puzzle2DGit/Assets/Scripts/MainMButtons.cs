using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class MainMButtons : MonoBehaviour
{
    public int level;
    void OnMouseDown()
    {
        SceneManager.LoadScene(level);
    }
}
