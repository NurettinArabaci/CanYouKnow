using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ChooseObjectType { True, False }

public class ChooseObject : MonoBehaviour
{
    public ChooseObjectType objType;
    Vector3 gap;
    float limitX = 4.5f;
    float limitY=10;

    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        Timer.Instance.gameObject.SetActive(false);

        if (other.tag=="True")
        {
            SuccessControl(ChooseObjectType.True, ChooseObjectType.False);
        }

        else if (other.tag=="False")
        {
            SuccessControl(ChooseObjectType.False, ChooseObjectType.True);
        } 
    }

    void OnMouseDown()
    {
        gap = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        PlayerMovement.isGround = false;
    }

    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition-gap);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -limitX, limitX),
                                         Mathf.Clamp(transform.position.y, 0.7f, limitY),
                                         Mathf.Clamp(transform.position.z,3.5f,5));
    }

    

    void SuccessControl(ChooseObjectType objeEnumTypeOne, ChooseObjectType objeEnumTypeTwo)
    {
        
        if (objType == objeEnumTypeOne)
        {
            GameManager.scoreAmount+=10;
            gameManager.score.GetComponent<Text>().text = GameManager.scoreAmount.ToString();

            PlayerMovement.isGround = true;
            GroundMovement.scrollSpeed = 1.5f;  
        }

        else if (objType == objeEnumTypeTwo)
        {
            Debug.Log("Oyunu kaybettin");
            GameManager.Instance.GameOverMethod();
           
        }
        GetComponent<PlayerMovement>().enabled = false;
    }
}
