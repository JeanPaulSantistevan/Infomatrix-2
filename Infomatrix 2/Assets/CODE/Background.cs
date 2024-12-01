using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMov; //para configurar la velocidad del movimiento del fondo Att JP
    private Vector2 offset; //un offset se refiere a un desplazamiento o cambio en la posición de un objeto o componente segun Copilot  en este caso del fondo al jugador xd
    private Material material;
    private Rigidbody2D jugadorRB;
    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        jugadorRB = GameObject.FindGameObjectWithTag("player").GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        offset = (jugadorRB.velocity.x * 0.1f) * velocidadMov* Time.deltaTime; //el tieme.deltatime deja igualado en cuestion de tiempo aunque tenga menos o mas fps
        material.mainTextureOffset += offset;
    }
}
