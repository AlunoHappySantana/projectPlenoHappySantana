using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistênciaObjeto : MonoBehaviour
{
    private static PersistênciaObjeto instancia;

    void Awake()
    {
        // Verifica se o objeto tem a tag correta
        if (gameObject.CompareTag("pastel"))
        {
            // Sistema de Singleton para evitar duplicatas ao voltar para a cena inicial
            if (instancia == null)
            {
                instancia = this;
                // Comando principal: impede que o objeto seja deletado na troca de cena
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                // Se já existir um "pastel" persistente, deleta a cópia nova
                Destroy(gameObject);
            }
        }
        else
        {
            Debug.LogWarning("O objeto " + gameObject.name + " não tem a tag 'pastel'!");
        }
    }

    // Exemplo de método para carregar a próxima cena
    public void MudarDeCena(string nomeDaCena)
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
