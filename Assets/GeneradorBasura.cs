using System.Collections;
using UnityEngine;

public class GeneradorBasura : MonoBehaviour
{
    // Aquí conectaremos tu Prefab de basura
    public GameObject basuraPrefab;
    public float tiempoAparicion = 5f; // Segundos de espera
    public float areaAparicion = 4f; // Qué tan lejos puede aparecer

    void Start()
    {
        // Inicia el ciclo repetitivo al empezar el juego
        StartCoroutine(AparecerBasura());
    }

    IEnumerator AparecerBasura()
    {
        while (true) // Esto hace que se repita para siempre
        {
            // 1. Espera 5 segundos
            yield return new WaitForSeconds(tiempoAparicion);

            // 2. Calcula una posición al azar en tu piso (X y Z)
            Vector3 posicionAleatoria = new Vector3(
                Random.Range(-areaAparicion, areaAparicion),
                0.2f, // Un poquito arriba del piso para que no se entierre
                Random.Range(-areaAparicion, areaAparicion)
            );

            // 3. ¡Crea la basura!
            Instantiate(basuraPrefab, posicionAleatoria, Quaternion.identity);
        }
    }
}