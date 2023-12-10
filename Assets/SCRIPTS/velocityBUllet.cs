using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;



public class VelocityBullet : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    public float velocidadY;
    public float direccionY;

    



    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(0, velocidadY * direccionY);
    }

    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        velocidadY = 3;
        direccionY = 3;


       
           
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }


        if (collision.gameObject.tag == "HORIZONTAL" || collision.gameObject.tag == "HORIZONTAL2")
        {
            Destroy(this.gameObject);
        }




    }


}
  

  


