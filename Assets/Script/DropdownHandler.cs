using UnityEngine;
using UnityEngine.UI;


public class DropdownHandler : MonoBehaviour
{
    Dropdown dropdown;

    private void Start()
    {
        dropdown = GetComponent<Dropdown>();
    }

    private void Update()
    {
        Debug.Log(dropdown.value);
    }
}
