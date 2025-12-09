using UnityEngine;

public class pastel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ingrediente"))
        {
            // Verifica o nome do objeto que tocou
            switch (other.gameObject.name)
            {
                case "queijo":
                    Debug.Log(1);
                    break;

                case "frango":
                    Debug.Log(2);
                    break;

                case "calabreso":
                    Debug.Log(3);
                    break;

                default:
                    Debug.Log("Ingrediente desconhecido: " + other.gameObject.name);
                    break;
            }
        }
    }
}
