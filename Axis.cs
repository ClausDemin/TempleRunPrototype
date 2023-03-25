using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis : MonoBehaviour
{
    public static float Horizontal;
    public static float Vertical;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            Horizontal = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Horizontal = -1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vertical = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vertical = -1;
        }
    }
}
