using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static bool isGround = true;

    void Update()
    {
        if (isGround==true)
        {
            transform.Translate(new Vector3(0, 0, -5 * Time.deltaTime));
        }
    }
}
