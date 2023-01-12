using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public AudioSource shoot;
    public UnityEvent bulletsDown;
    public UnityEvent reload;

    public float bulletforce = 20f;
    float timeLastShot = 0f;
    float delayBetweenShots = 0.17f;
    float timeLastBullet = 0f;
    int bullets = 12;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && bullets > 0)
        {
            Shoot();
        }
        /*if (Input.GetKey(KeyCode.Mouse0) && (Time.time > timeLastShot + delayBetweenShots) && bullets > 0)
        {
            timeLastShot = Time.time;
            Shoot();
            //for(int i = 0; i< 5; i++)
            //{
            //if (Time.time > timeLastShot + 0.05f)
            //{

            //}

            //}


            //Invoke("wait", 1f);
        }*/
    }

    void Shoot()
    {
        shoot.Play();
        timeLastBullet = Time.time;
        GameObject bullet = Instantiate( bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.right * bulletforce, ForceMode2D.Impulse);
        bullets--;
        bulletsDown.Invoke();
        //}
        //if (Input.GetKey(KeyCode.Mouse1))
        // {
        //   bulletPrefab.SetActive(false);
        // }
    }

    public void reloadBullets()
    {
        bullets = bullets + 6;
        if (bullets >= 12)
        {
            bullets = 12;
        }
        reload.Invoke();
    }
}
