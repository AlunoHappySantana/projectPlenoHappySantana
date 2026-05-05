using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Clientes : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

public class TempoAleatorio : MonoBehaviour
{
    public int numeromaneiro;
    public int tempomaneiro = 0;
    public bool podevim = false;
    void Start()
    {
        numeromaneiro = Random.Range(1, 4);
        tempomaneiro = (int)(numeromaneiro * Time.deltaTime);

        if( tempomaneiro != 0) {
            podevim = true;
        }
    }
}