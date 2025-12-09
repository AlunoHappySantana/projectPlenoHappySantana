using UnityEngine;
public class frango : MonoBehaviour
{
    private Transform ingredienteAtual; 
    private Vector2 offset;

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Quando apertar o mouse
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D hit = Physics2D.OverlapPoint(mousePos);

            if (hit != null && hit.CompareTag("Ingrediente"))
            {
                ingredienteAtual = hit.transform;

                offset = (Vector2)ingredienteAtual.position - mousePos;
            }
        }

        // Arrastando
        if (Input.GetMouseButton(0) && ingredienteAtual != null)
        {
            ingredienteAtual.position = mousePos + offset;
        }

        // Soltou o mouse → parar de arrastar
        if (Input.GetMouseButtonUp(0))
        {
            ingredienteAtual = null;
        }
    }
}
