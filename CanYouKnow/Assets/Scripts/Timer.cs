using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer Instance;

    Text counterText;
    public static int duration;
    public static int currentTime;

    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        duration = 5;
        currentTime = duration;
        counterText = GetComponent<Text>();

        StartCoroutine(CounterBack());
    }
    
  
    IEnumerator CounterBack()
    {
        while (currentTime>=0)
        {
            counterText.text = currentTime.ToString();
            
            yield return new WaitForSeconds(1f);
            currentTime--;
            if (currentTime<=0)
            {

            }
            
        }
            
        
        
    }
}
