using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // A esfera que a câmera deve seguir
    public Vector3 offset;   // Offset da posição da câmera em relação à esfera
    public float smoothSpeed = 0.125f; // Velocidade de suavização do movimento da câmera

    void LateUpdate()
    {
        // Calcula a nova posição da câmera com base na posição da esfera e o offset
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        // Atualiza a posição da câmera
        transform.position = smoothedPosition;

        // Opcional: Faz a câmera olhar para a esfera
        transform.LookAt(target);
    }
}
