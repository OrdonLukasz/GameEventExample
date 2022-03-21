using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListenerEndTask : GameEventListener
{
    [SerializeField] UnityEvent endTaskGameEvent;
    [SerializeField] private float delayTime = 2.0f;
    [SerializeField] private bool isTaskEnded = false;
   
    public override void RaiseEvent()
    {
        unityEvent.Invoke();
        StartCoroutine(SetDisplayedTextDelay());
    }

    private IEnumerator SetDisplayedTextDelay()
    {
        yield return new WaitForSeconds(delayTime);
        endTaskGameEvent.Invoke();
    }

    public void SetTaskState()
    {
        isTaskEnded = true;
    }
}
