using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    public Transform gunTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       Vector3 direction = mousePosition - gunTransform.position;
       float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
       gunTransform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
