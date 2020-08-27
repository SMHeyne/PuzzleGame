using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject Overlay;

    public void Load  (int i)
    {
        SceneManager.LoadScene(i);
    }
    private void Update()
    {

        if (Overlay != null && Input.GetKeyDown(KeyCode.Escape))
        {
            bool isActive = Overlay.activeSelf;

            Overlay.SetActive(!isActive);
        }


        /**
       if (Input.GetKey(KeyCode.Escape))
       {
           GameObject escOV = GetComponent < OverlaySetActive>().Overlay;
           bool isActive = escOV.activeSelf;

           escOV.SetActive(!isActive);
       }
       */


        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OpenOverlay()
    {
        if (Overlay != null)
        {
            bool isActive = Overlay.activeSelf;

            Overlay.SetActive(!isActive);
        }
    }

}



