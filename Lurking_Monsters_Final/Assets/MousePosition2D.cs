using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition2D : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;
        transform.position = mousePosition;

    }
}
