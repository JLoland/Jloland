using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Swipe : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private MarkersChanger markerChanger;

    public enum DraggedDirection
    {
        Left,
        Right,
        Up,
        Down
    }

    private void Start()
    {
        markerChanger = FindObjectOfType<MarkersChanger>();
    }

    public void OnDrag(PointerEventData data)
    {

    }

    public void OnEndDrag(PointerEventData data)
    {
        Vector3 dragVectorDirection = (data.position - data.pressPosition).normalized;
        DraggedDirection dragDir = GetDragDirection(dragVectorDirection);
        switch (dragDir)
        {
            case DraggedDirection.Left:
                markerChanger.NextModel();
                break;
            case DraggedDirection.Right:
                markerChanger.PreviousModel();
                break;
        }
    }

    private DraggedDirection GetDragDirection(Vector3 dragVector)
    {
        float positiveX = Mathf.Abs(dragVector.x);
        float positiveY = Mathf.Abs(dragVector.y);
        DraggedDirection draggedDir;
        if (positiveX > positiveY)
        {
            draggedDir = (dragVector.x > 0) ? DraggedDirection.Right : DraggedDirection.Left;
        }
        else
        {
            draggedDir = (dragVector.y > 0) ? DraggedDirection.Up : DraggedDirection.Down;
        }
        return draggedDir;
    }
}
