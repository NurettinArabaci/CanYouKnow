using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GroundMovement : MonoBehaviour
{
    Material groundMat;

    float offset;
    public static float scrollSpeed=-1.5f;

    private void Awake()
    {
        groundMat = GetComponent<MeshRenderer>().material;
    }
    void Start()
    {
       // groundMat.DOOffset(new Vector2(0, -100), 200);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Selectable") PlayerMovement.Instance.isGround = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag== "Selectable") PlayerMovement.Instance.isGround = false;
    }

    private void Update()
    {
        offset = Time.time * scrollSpeed;
        groundMat.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
