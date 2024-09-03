using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimentação da esfera

    void Update()
    {
        // Captura a entrada do teclado
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Cria um vetor de movimento com base na entrada do teclado
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;

        // Aplica o movimento à posição da esfera
        transform.Translate(movement, Space.World);
    }
}
