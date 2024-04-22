using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardController : MonoBehaviour
{
    Vector2 diference = Vector2.zero;
    bool isDragging = false;
    Vector2 slotPosition = new Vector2(0, 0);
    
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Card collided with slot");

        if (collision.name == "Slot" || collision.name == "Slot(Clone)") {
            Debug.Log("Card entered the slot");
            isDragging = true;
            slotPosition = collision.transform.position;
            collision.gameObject.SetActive(false);
        }   
    }

    private void OnMouseDown() {
        diference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    private void OnMouseDrag() {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - diference;
        if (isDragging) {
            transform.position = slotPosition;
            }
        }
}
