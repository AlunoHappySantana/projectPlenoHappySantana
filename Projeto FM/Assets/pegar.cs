using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start();

    public float frituTimer = 5f;

    public bool mensag = false;
    private bool arrastando = false;
    private Vector3D deslocamento;
    private bool naFrigideira = false;
    private Transform frigideiraPosition;
    private bool fritando = false;
    private bool pronto = false;
    private float contTempo = 0f;

    private Rigidbody2D rb;
    private bool entregue = false;

    void Awake() //awake é chamado quandoo o objetivo é instanciadl
    {
        rb = GetComponent<Rigidbody2D>();


    }

    void OnMouseDown() {
        if (fritando)
        {
            if (mensag)
            {
                Debug.log("Nao pode pegar o pastel bobao");
                 return;
            } 
        }
        Vector3D mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

}