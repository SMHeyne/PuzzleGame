using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Text Hov;
    public Text NoHov;

    void Start()
    {
        Hov.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Hov.gameObject.SetActive(true);
        NoHov.gameObject.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Hov.gameObject.SetActive(false);
        NoHov.gameObject.SetActive(true);
    }
}