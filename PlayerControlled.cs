using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SimpleInputNamespace;

public class PlayerControlled : MonoBehaviour
{

    public Rigidbody2D _rigidbody;
    Animator _anim;
    public Text ScoreBoard;
    public AudioSource jumpSound;
    public AudioSource overSound;
    public AudioSource coinSound;
    public AudioSource enemyDeath;
    public int jumpSpeed = 0;
    public bool zeminKontrol = true;
    public int hareketHiz = 0;
    int coinCount = 0;
    public GameObject gameOverPanel;

    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        coinCount = PlayerPrefs.GetInt("Coin");  //Regedit'e kaydettigimiz degeri çek.
        ScoreBoard.text = "Skor: " + coinCount;
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Zipla();*/
        Hareket();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Zipla();
        }

    }

    public void Zipla()
    {
        if (/*Input.GetKeyDown(KeyCode.Space) &&*/ zeminKontrol)
        {
            _rigidbody.AddForce(Vector2.up * jumpSpeed);
            zeminKontrol = false;
            _anim.SetBool("Zipla",true);
            jumpSound.Play();

        }

    }

    public float x;
    void Hareket()
    {
        x = SimpleInput.GetAxis("Horizontal");
        Vector2 hareket = new Vector2(x * hareketHiz,_rigidbody.velocity.y);

        _rigidbody.velocity = hareket;

        if(x < 0)
        {
            transform.localScale = new Vector2(-1, 1);
            _anim.SetFloat("Run", Mathf.Abs(x));
        }
        if(x > 0)
        {
            transform.localScale = new Vector2(1, 1);
            _anim.SetFloat("Run", x);
        }


        

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            zeminKontrol = true;
            _anim.SetBool("Zipla", false);
        }

        if (collision.gameObject.tag == "Enemy")  //(gameObject.CompareTag("Enemy"))
        {
            enemyDeath.Play();
            Destroy(collision.gameObject);  //Destroy komutu objeleri kaldýr.
        }
        
    }
    //OnCollisionExit2D OnCollisionStay2D OnCollisionEnter2D

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "GameOver")
        {
            overSound.Play();
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }

        if(collision.gameObject.tag == "Coin")
        {
            
            coinSound.Play();
            coinCount++;

            /*if(coinCount == 5)
            {
                coinCount = 0;
            }*/
            ScoreBoard.text = "Skor:" + coinCount;
            PlayerPrefs.SetInt("Coin", coinCount); //regedit kaydet ||veya &&ve
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Level 2");
        }

    }
}
    