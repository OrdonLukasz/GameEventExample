using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDisplayTask : MonoBehaviour
{
    [SerializeField] GameEvent onClicked;
    [SerializeField] GameObject objectToClick;

    public bool isClicked;

    void OnMouseDown()
    {
        if (isClicked == false)
        {
            Clicked();
        }
    }

    void Clicked()
    {
        objectToClick.SetActive(false);
        onClicked?.Invoke();
        isClicked = true;
    }
}
