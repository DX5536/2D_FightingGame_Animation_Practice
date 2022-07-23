using TMPro;
using UnityEngine;

public class Slot: MonoBehaviour
{
    [SerializeField]
    private string playerTag = "Player";

    [SerializeField]
    private DragLine dragLine;

    [SerializeField]
    private bool isPlaced;

    [SerializeField]
    private GameObject circle_0;

    [SerializeField]
    private GameObject slot;

    [SerializeField]
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        slot = this.gameObject;
        textMeshPro.enabled = false;
    }

    void Update()
    {

        if (isPlaced && !dragLine.IsDragging)
        {
            textMeshPro.enabled = true;
            Debug.Log("MouseUp isPlaced in " + slot.name);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == playerTag)
        {
            circle_0.transform.position = (Vector2) slot.transform.position;
            isPlaced = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == playerTag)
        {
            isPlaced = false;
            textMeshPro.enabled = false;
        }
    }
}