using UnityEngine;


public class ExplosionEnemyController : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private Animator _compAnimator;
    private AudioSource _audioSource;
    
    
    public ActualizarPuntaje gameManager;

    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compAnimator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();

       
       

      
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bala")
        {
            _compAnimator.SetTrigger("IsExploting");
            _audioSource.Play();

            gameManager.CantidadPuntos(3);
        }

        else if ( collision.gameObject.tag == "HORIZONTAL")
        {
            _compAnimator.SetTrigger("IsExploting");
            _audioSource.Play();
        }



    }

    public void Muerte()
    {
        Destroy(this.gameObject);
       
    }

   public void SetGameManager(ActualizarPuntaje gm)
    {
        gameManager = gm;
    }
}