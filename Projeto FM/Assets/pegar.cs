using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegar : MonoBehaviour
{
    // Start is called before the first frame update
//<<<<<<< HEAD

//>>>>>> 6d285ccd689f460f9719968106c35d71712ed90c

    public float frituTimer = 5f;

    public bool mensag = false;
    private bool arrastando = false;
//<<<<<<< HEAD
    
//=======
    private Vector3 deslocamento;
//>>>>>> 6d285ccd689f460f9719968106c35d71712ed90c
    private bool naFrigideira = false;
    private Transform frigideiraPosition;
    private bool fritando = false;
    private bool pronto = false;
    private float contTempo = 0f;

    private Rigidbody2D rb;
    private bool entregue = false;
//<<<<<<< HEAD

//=======
    
//>>>>>>> 6d285ccd689f460f9719968106c35d71712ed90c
    void Awake() //awake é chamado quandoo o objetivo é instanciadl
    {
        rb = GetComponent<Rigidbody2D>();


    }

    void OnMouseDown() {
        if (fritando)
        {
            if (mensag)
            {
/*<<<<<< HEAD
                Debug.log("Nao pode pegar o pastel bobao");
                 return;
            
        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePositionss);
    



                Debug.Log("Nao pode pegar o pastel bobao");
                 return;
            } 
        }
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

}
6d285ccd689f460f9719968106c35d71712ed90c*/
            }
        }
    }
}
