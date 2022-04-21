using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDisplayTask : MonoBehaviour
{
    public bool isClicked;
    
    [SerializeField] GameEvent onClicked;
    [SerializeField] GameObject objectToClick;

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
