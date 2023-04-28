using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDrag : MonoBehaviour
{
    private bool check;
    Vector3 offset;

    void OnMouseDown()
    {
        check = true;
    }

    void OnMouseDrag()
    {
        if (check)
        {
            float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            Vector3 mouse_pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen);
            Vector3 object_pos = Camera.main.ScreenToWorldPoint(mouse_pos);

            // Keep the y position constant
            object_pos.y = transform.position.y;

            transform.position = object_pos;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        check = true;
    }
}
