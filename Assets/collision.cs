using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        
    }

    //public Vector3 moveDirection = new Vector3(1, 0, 0); // Direction du mouvement
    //public float moveSpeed = 5f; // Vitesse du mouvement

    //void OnCollisionEnter(Collision collision)
    //{
    //    // V�rifie si l'objet qui entre en collision a le tag souhait�
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        // Applique un mouvement � cet objet
    //        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    //    }
    //}

    public float forceMultiplier = 10f; // Multiplieur pour ajuster la force appliqu�e

    private Rigidbody rb;

    void Start()
    {
        // Obtenir le Rigidbody de l'objet
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Calculer la force de la collision
            Vector3 collisionForce = collision.impulse / Time.fixedDeltaTime;

            // Appliquer une force proportionnelle � l'impact, ajust�e par le multiplicateur
            rb.AddForce(collisionForce * forceMultiplier, ForceMode.Impulse);
        }
    }


}
