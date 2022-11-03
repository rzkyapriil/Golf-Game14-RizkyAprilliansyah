using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerDownHandler
{
    private bool mouseEnter = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Click");
        mouseEnter = true;
    }

    void Update()
    {
        if (mouseEnter)
        {
            FindObjectOfType<AudioManager>().PlayAudio("Mouse Enter");
        }
    }
}
