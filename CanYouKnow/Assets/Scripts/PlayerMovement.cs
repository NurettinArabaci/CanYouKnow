using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isGround = true;

    public static PlayerMovement Instance;

    private void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        if (isGround==true)
        {
            transform.Translate(new Vector3(0, 0, -5 * Time.deltaTime));
        }
    }
}
