using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverlaySetActive : MonoBehaviour
{
    public GameObject Overlay;

    // Start is called before the first frame update
    public void OpenOverlay()
    {
        if(Overlay != null)
        {
            bool isActive = Overlay.activeSelf;

            Overlay.SetActive(!isActive);
        }
    }
}
