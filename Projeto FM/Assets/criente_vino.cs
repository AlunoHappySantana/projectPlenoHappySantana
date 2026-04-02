using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criente_vino : MonoBehaviour
{
    public Animator anim;
    bool podevim = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (podevim == true)
        {
            anim.Play("cliente entrando");
        }
        else
        {
            anim.Play("cliente parado");
        }
    }
}