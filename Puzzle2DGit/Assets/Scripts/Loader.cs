using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Loader : MonoBehaviour
{


    public void Load  (int i)
    {
        SceneManager.LoadScene(i);
    }

}



