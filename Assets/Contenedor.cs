using UnityEngine;
using TMPro; // Necesario para el texto

public class Contenedor : MonoBehaviour
{
    public int puntos = 0;
    public TextMeshProUGUI textoContador; // Aquí arrastraremos tu texto

    void OnTriggerEnter(Collider otro)
    {
        // Si lo que entró al bote tiene la etiqueta "Basura"
        if (otro.CompareTag("Basura"))
        {
            puntos++; // Suma 1 punto
            textoContador.text = "Basura: " + puntos; // Actualiza la pantalla
            Destroy(otro.gameObject); // Destruye la basura
        }
    }
}