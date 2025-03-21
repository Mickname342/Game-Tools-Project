using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    GrappleHook gh;
    public SpriteRenderer Gunman;
    public Animator anim;
    public BoxCollider2D collider2;
    public SpriteRenderer charachter;
    public Color colorToTurnTo = Color.white;
    public UnityEvent hpLost;
    public UnityEvent hpGained;
    public AudioSource hit;

    [SerializeField] float speed = 5f;

    float mx;
    float my;
    public float hp = 5;
    private Vector2 playerDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gh = GetComponent<GrappleHook>();
    }

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");
        my = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(mx, my).normalized;
        if(playerDirection.x < 0)
        {
            Gunman.flipX = true;
        }
        else if (playerDirection.x > 0)
        {
            Gunman.flipX = false;
        }

        if (hp < 0.1f)
        {
            GameObject.Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirection.x * speed, playerDirection.y * speed);
        //if (!gh.retracting)
        //{
          //  rb.velocity = new Vector2(mx, my).normalized * speed;
        //}
        //else
        //{
          //  rb.velocity = Vector2.zero;
        //}
        if (rb.velocity.magnitude != 0)
        {
            anim.SetBool("move", true);
        }
        else
        {
            anim.SetBool("move", false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.layer == 0)
        {
            hit.Play();
            hp--;
            collider2.enabled = false;
            charachter.color = colorToTurnTo;
            hpLost.Invoke();
            Invoke("invincibility", 2f);

        }
        
    }

    void invincibility()
    {
        collider2.enabled = true;
        charachter.color = Color.white;
    }

    public void hpUp()
    {
        if (hp < 5)
        {
            hp++;
            hpGained.Invoke();
        }
        else
        {
            hp = 5;
        }
    }
}
