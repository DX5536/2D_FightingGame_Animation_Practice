using UnityEngine;


public class DragLine: MonoBehaviour
{
    [SerializeField]
    private bool isDragging;
    [SerializeField]
    private Vector2 offset;

    public bool IsDragging
    {
        get => isDragging;
        set => isDragging = value;
    }

    void Start()
    {

    }

    void Update()
    {
        if (!isDragging)
        {
            return;
        }
        else
        {
            var mousePosition = GetMousePos();
            transform.position = mousePosition - offset;
        }
    }

    private void OnMouseDown()
    {
        isDragging = true;
        offset = GetMousePos() - (Vector2) transform.position;
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}