using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChooseObjectType { True, False }

public class ChooseObject : MonoBehaviour
{
    public static ChooseObject Instance;

    public ChooseObjectType objType;

    Vector3 gap;

    public float limitX,limitY;

    private void Awake()
    {
        Instance = this;
    }

    private void OnMouseDown()
    {
        gap = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition-gap);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -limitX, limitX), Mathf.Clamp(transform.position.y, 0.5f, limitY), transform.position.z);

    }

}
