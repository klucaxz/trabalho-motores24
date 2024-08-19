using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class player : MonoBehaviour
{
    public int velocidade = 10;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse );
                                                                                                                           
    }
}
