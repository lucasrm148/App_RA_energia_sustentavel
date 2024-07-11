using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eletron_move : MonoBehaviour
{
    public string type = "ordenado";
    public Vector3 direcao = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        if (this.type == "ordenado")
        {
            movimento_ordenado(direcao);
        }else
        {
            movimento_aleatorio();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void movimento_ordenado(Vector3 direcao){ 
        this.GetComponentInParent<Rigidbody>().velocity = direcao;
    }
    private void movimento_aleatorio()
    {
        Vector3 vector = Vector3.zero;
        vector.x = Random.Range(50, 100);
        vector.y = Random.Range(50, 100);
        vector.z = Random.Range(50, 100);
        this.GetComponentInParent<Rigidbody>().velocity = vector;
    }
    void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Calcula a direção de ricochete usando a normal da colisão
            Vector3 direction = Vector3.Reflect(rb.velocity.normalized, collision.contacts[0].normal);

            // Aplica força aos objetos para refleti-los
            rb.velocity = direction * rb.velocity.magnitude;
            this.GetComponent<Rigidbody>().velocity = - direction * GetComponent<Rigidbody>().velocity.magnitude;
        }
    }
}
