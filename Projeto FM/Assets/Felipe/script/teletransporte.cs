using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistenciaObjeto : MonoBehaviour
{
    // Instância estática que será acessada por outros scripts se necessário
    public static PersistenciaObjeto instancia;

    void Awake()
    {
        // Verifica se já existe uma instância deste objeto
        if (instancia == null)
        {
            instancia = this;
            
            // Verifica se o objeto é um objeto de topo (raiz). 
            // DontDestroyOnLoad só funciona em objetos que não têm "pai".
            transform.SetParent(null); 
            
            
            
        }
        else if (instancia != this)
        {
            // Se já existir uma instância e não for esta, destrói a duplicata
            Debug.Log("Duplicata de " + gameObject.name + " destruída.");
            Destroy(gameObject);
        }
    }

    // Método para mudar de cena
   private void OnTriggerEnter2D(Collider2D Banana)
   {
    if (Banana.CompareTag("Ingrediente"))
        {
            TrocarImagem();
            Destroy(Banana.gameObject);
        }

        if (Banana.CompareTag("pontoFritar"))
        {
            SceneManager.LoadScene("SalaDeFritura");
            Destroy(Banana); 
          
            
        }
   }

public Sprite PastelCru;

private SpriteRenderer spriteRenderer;
   void TrocarImagem()
    {
        if (PastelCru != null)
        {
            spriteRenderer.sprite = PastelCru;
        }
    }
   
}