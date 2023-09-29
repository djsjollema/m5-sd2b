using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragablePoint : MonoBehaviour
{
    [SerializeField] private bool dragging = false;

    void Start()
    {
        
    }

    void Update()
    {
        dragDot();
    }
    private void dragDot() {
        if (dragging)
        {
            Vector2 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            this.transform.position = mousePosition;
        }
    }
    private void OnMouseDown()
    {
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
    }
}
