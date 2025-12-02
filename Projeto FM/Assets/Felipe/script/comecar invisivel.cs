using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ToggleVisibilityOnCollision : MonoBehaviour
{
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        // Começa invisível
        sr.enabled = false;
    }

  
}
