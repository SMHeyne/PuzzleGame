using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public GameObject EndScrn;

    public void Start()
    {
        EndScrn.gameObject.SetActive(false);
    }

    public void callEnd()
    {
        EndScrn.gameObject.SetActive(true);
    }

}
