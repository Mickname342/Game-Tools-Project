using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{

    public Text bullets;
    public Text bears;
    public Image[] keys = new Image[3];
    public Sprite Key;

    int totalBullets = 12;
    int totalBears = 3;
    int collectedKeys = 0;

    void Start()
    {
        bullets.text = totalBullets.ToString();
        bears.text = totalBears.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        bullets.text = totalBullets.ToString();
        bears.text = totalBears.ToString();
    }

    public void bulletsDown()
    {
        totalBullets--;
    }

    public void bullestReload()
    {
        totalBullets = totalBullets + 6;
        if(totalBullets >= 12)
        {
            totalBullets = 12;
        }
    }

    public void hpDown()
    {
        totalBears--;
    }

    public void keyUP()
    {
        collectedKeys++;
        if (collectedKeys == 1)
        {
            keys[0].gameObject.GetComponent<Image>().sprite = Key;
        }
        if (collectedKeys == 2)
        {
            keys[1].gameObject.GetComponent<Image>().sprite = Key;
        }
        if (collectedKeys == 3)
        {
            keys[2].gameObject.GetComponent<Image>().sprite = Key;
        }
    }
}
