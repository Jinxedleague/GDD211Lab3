using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody ballRB;
    public GameObject cam;
    public GameObject inventoryPanel;
    private Boolean inventoryBool;
    public int health;
    public int shp;
    public int lhp;
    public int fhp;
    public Text shpText;
    public Text lhpText;
    public Text fhpText;
    public Text healthText;

    void Start()
    {
        inventoryPanel.SetActive(false);
        inventoryBool = false;
        shp = 0;
        lhp = 0;
        fhp = 0;
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            ballRB.AddForce(new Vector3(1f, 0f, 0f), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            ballRB.AddForce(new Vector3(-1f, 0f, 0f), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            ballRB.AddForce(new Vector3(0f, 0f, 1f), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ballRB.AddForce(new Vector3(0f, 0f, -1f), ForceMode.Force);
        }

        cam.transform.position = new Vector3(this.transform.position.x - 5, this.transform.position.y + 5, this.transform.position.z);

        if(Input.GetKeyDown(KeyCode.I))
        {
            if(inventoryBool == true)
            {
                inventoryPanel.SetActive(false);
                inventoryBool = false;
            }
            else
            {
                inventoryPanel.SetActive(true);
                inventoryBool = true;
            }
        }

        shpText.text = "Small Health Potions: " + shp;
        lhpText.text = "Large Health Potions: " + lhp;
        fhpText.text = "Full Health Potions: " + fhp;
        healthText.text = "Health: " + health;

        if(health == 0)
        {
            SceneManager.LoadScene("Loss");
        }
    }

    public void useSmallPot()
    {
        if(shp > 0)
        {
            if(health < 75)
            {
                health += 25;
            }
            else
            {
                health = 100;
            }
            shp--;
        }
    }

    public void useLargePot()
    {
        if (lhp > 0)
        {
            if (health < 50)
            {
                health += 50;
            }
            else
            {
                health = 100;
            }
            lhp--;
        }
    }

    public void useFullPot()
    {
        if(fhp > 0)
        {
            health = 100;
        }
        fhp--;
    }

    public void takeDamage(int damageTaken)
    {
        if (health >= damageTaken)
        {
            health -= damageTaken;
        }
        else
        {
            health = 0;
        }
    }
    public int getHealth()
    {
        return health;
    }
    public void setScore(int healthMod)
    {
        health = healthMod;
    }

    public int getScore()
    {
        return health;
    }

    public void modifyPotionCount(int sp, int lp, int fp)
    {
        shp = shp + sp;
        lhp = lhp + lp;
        fhp = fhp + fp;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("end"))
        {
            SceneManager.LoadScene("End");
        }
        if (collision.gameObject.CompareTag("death"))
        {
            SceneManager.LoadScene("Loss");
        }
    }
}
