using UnityEngine;

public class MovimientoCinematica : MonoBehaviour
{
    public float distancia = 10f;
    public float duracion = 2f;
    private Vector3 posicionInicial;
    private bool moverDerecha = false;
    private bool moverIzquierda = false;
    private float tiempoTranscurrido = 0f;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        if (moverDerecha)
        {
            tiempoTranscurrido += Time.deltaTime;
            float porcentajeCompletado = tiempoTranscurrido / duracion;
            transform.position = Vector3.Lerp(posicionInicial, posicionInicial + Vector3.right * distancia, porcentajeCompletado);

            if (porcentajeCompletado >= 1f)
            {
                moverDerecha = false;
                tiempoTranscurrido = 0f;
            }
        }
        else if (moverIzquierda)
        {
            tiempoTranscurrido += Time.deltaTime;
            float porcentajeCompletado = tiempoTranscurrido / duracion;
            transform.position = Vector3.Lerp(posicionInicial + Vector3.right * distancia, posicionInicial, porcentajeCompletado);

            if (porcentajeCompletado >= 1f)
            {
                moverIzquierda = false;
                tiempoTranscurrido = 0f;
            }
        }
    }

    public void MoverDerecha()
    {
        moverDerecha = true;
    }

    public void MoverIzquierda()
    {
        moverIzquierda = true;
    }
}

