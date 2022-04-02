using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinishController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "StartPoint")
        {
            if(gameObject.tag== "FinishObj")
            {
                GameManager.Instance.LevelCompleteMethod();
                gameObject.SetActive(false);
            }
            else
            {
                Timer.Instance.gameObject.SetActive(true);
            }

            
        }

        else if (other.tag == "FinishPoint")
        {
            GameManager.Instance.GameOverMethod();
            
        }
       
    }
}
