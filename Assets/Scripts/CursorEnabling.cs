using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorEnabling : MonoBehaviour
{
    private void OnEnable()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void OnDisable()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
