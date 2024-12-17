using System;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 7;
    public bool noChao;
    
    private Rigidbody rb;
    private AudioSource source;

    void Start()
    {
        // Inicializa o componente Rigidbody
        TryGetComponent(out rb);
        TryGetComponent(out source);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!noChao && collision.gameObject.tag == "Chão")
        {
            noChao = true; 
        }
    }


    void Update()
    {
        if (rb != null)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Vector3 direcao = new Vector3(h, 0, v);
            rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);

            // Adiciona força para pular
            if (Input.GetKeyDown(KeyCode.Space) && noChao)
            {
                
                source.Play();
                
                rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
                noChao = false;
            }
        }

        // Recarrega a cena se o jogador cair abaixo do limite
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
