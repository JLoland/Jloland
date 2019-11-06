using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[Serializable]
public class GameObjectUnityEvent : UnityEvent<GameObject> { }

public class MarkersChanger : MonoBehaviour
{
    public GameObject currentInstance;
    public List<GameObject> markers;
    private int markerIndex;

    public GameObjectUnityEvent response;

    private void OnEnable()
    {
        if (markers.Count > 0) InstantiateByIndex(0);
    }

    private void InstantiateByIndex(int _index)
    {
        if (currentInstance)
            Destroy(currentInstance);
        currentInstance = Instantiate(markers[_index]);
        response.Invoke(currentInstance);
        markerIndex = _index;
    }

    public void PreviousModel()
    {
        int numerator;
        if (markerIndex == 0) numerator = markers.Count - 1;
        else numerator = markerIndex - 1;
        InstantiateByIndex(numerator);
    }

    public void NextModel()
    {
        int numerator = 0;
        if (markerIndex == markers.Count - 1) numerator = 0;
        else numerator = markerIndex + 1;
        InstantiateByIndex(numerator);
    }

}