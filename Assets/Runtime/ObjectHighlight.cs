using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ObjectHighlight : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    public CustomEvent onSelectObject;
    public CustomEvent onDeselectObject;

    private void Start()
    {
        onDeselectObject?.Invoke();
    }

    public void OnDeselect(BaseEventData eventData)
    {
        onDeselectObject?.Invoke();
    }

    public void OnSelect(BaseEventData eventData)
    {
        onSelectObject?.Invoke();
    }
}
[System.Serializable]
public class CustomEvent : UnityEvent { }
