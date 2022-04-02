using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinishController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "StartPoint")
        {

            Timer.Instance.gameObject.SetActive(true);
        }

        else if (other.tag == "FinishPoint")
        {
            //gameover butonunu aktif et
        }
    }
}
