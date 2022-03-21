using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToEnable : MonoBehaviour
{
    [SerializeField] MonoBehaviour target;

    private void OnMouseDown()
    {
        target.enabled = true;
    }
}
