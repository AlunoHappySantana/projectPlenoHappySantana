using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedidos : MonoBehaviour
{
    // Start is called before the first frame update
        float timeRemaining = 10f;
         bool timerIsRunning = true;
        int[] sabor = {1, 2, 3}; //1 = frango, 2 = queijo, 3 = calabreso
    void Start()
    {
 

    }

    // Update is called once per frame
    void Update()
    {
        int randomInt = Random.Range(1, 3);
        
        if (timerIsRunning == true && timeRemaining > 0) {
            timeRemaining -= Time.deltaTime;
        if (timeRemaining <= 0) {
            timeRemaining = 10f;
            sabor[0] = randomInt;
            sabor[1] = randomInt;
            sabor[2] = randomInt;
            
            }
        }
        Debug.Log(sabor);
    }
}
