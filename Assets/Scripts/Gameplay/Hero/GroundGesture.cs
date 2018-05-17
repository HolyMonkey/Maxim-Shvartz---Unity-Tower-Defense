using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GroundGesture : MonoBehaviour, IPointerClickHandler {

    public UnityAction<Vector3> OnTap;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(OnTap != null)
        {
            OnTap.Invoke(eventData.pointerCurrentRaycast.worldPosition);
        }
        Debug.Log(eventData.pointerCurrentRaycast.worldPosition);
    }
}
