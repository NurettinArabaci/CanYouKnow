using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseSide : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<ChooseObject>().objType == ChooseObjectType.False)
        {
            
            Debug.Log("Bildin");
        }
        else
        {
            
            Debug.Log("Olmadı yar");
        }
        PlayerMovement.Instance.isGround = true;
    }
}
