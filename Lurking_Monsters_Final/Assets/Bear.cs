using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Pathfinding;

public class Bear : MonoBehaviour
{
    public int hp = 3;
    public int maxHp = 3;
    public Transform hpBar;
    public UnityEvent activate;
    public UnityEvent dead;
    public AudioSource roar;
    public GameObject rechargePrefab;
    public Animator anim;
    public AIPath aipath;
    public SpriteRenderer spriteRenderer;
    int random;

    private void Start()
    {
        random = Random.Range(0,10);
        hpBar.localScale = new Vector2(maxHp, 1);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        hp--; 
        hpBar.localScale = new Vector2(hpBar.localScale.x - 1,1);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        activate.Invoke();
        anim.SetBool("Active", true);

    }

    private void Update()
    {
        if (hp <= 0)
        {
            dead.Invoke();
            if (random <= 6)
            {
                Instantiate(rechargePrefab, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }

        if (aipath.desiredVelocity.x >= 0.01f)
        {
            spriteRenderer.flipX = false;
        }
        else if (aipath.desiredVelocity.x <= -0.01f)
        {
            spriteRenderer.flipX = true;
        }
        
    }
}

