using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    private Camera myCam;
    private Vector3 screenPos;
    private float angleOffset;

    // Start is called before the first frame update
    void Start()
    {
        myCam = Camera.main;
    }

    void OnMouseDown()
    {
        screenPos = myCam.WorldToScreenPoint(transform.position);
        Vector3 v3 = Input.mousePosition - screenPos;
        angleOffset = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(v3.y, v3.x)) * Mathf.Rad2Deg;
    }

    void OnMouseDrag()
    {
        Vector3 v3 = Input.mousePosition - screenPos;
        float angle = Mathf.Atan2(v3.y, v3.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle + angleOffset);
    }
}
