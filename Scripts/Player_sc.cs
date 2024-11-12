using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player_sc : MonoBehaviour
{
    [SerializeField]
    int lives = 3;
    [SerializeField]
    public float speed = 5.0f;
    public GameObject laserprefab;
    public float firerate = 0.5f;
    public float nextfire = 1f;

    [SerializeField]
    bool istripleshot = false;

    [SerializeField]
    GameObject tripleShotPrefab;

    
    
    spawnManager_sc spawnManager_Sc;


    void Start()
{
    spawnManager_Sc = GameObject.Find("spawnManager").GetComponent<spawnManager_sc>();

        if (spawnManager_Sc == null)
        {
            Debug.Log("Spwan_Manager oyun nesnesi bulunmadi");

        }
    
}




    void Update()
    {
        movement();



        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextfire)
        {
            attack();
        }
    }



    void attack()
    {
        if (istripleshot)
        {
            Instantiate(tripleShotPrefab, transform.position + new Vector3(-3.963f, -2.143f, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(laserprefab, transform.position + new Vector3(0f, 1f, 0), Quaternion.identity);

        }

        nextfire = Time.time + firerate;
    }

    public void Demage()
    {
        lives--;
        if (lives < 1)
        {
           if (spawnManager_Sc != null)
                spawnManager_Sc.OnPlayerDeath();
            Destroy(this.gameObject);

        }
    }

    public void ActivateTripleShot()
    {
        istripleshot = true;

        
        istripleshot = false;
    }


    void movement()
    {
        float dikey = Input.GetAxis("Vertical");
        float yatay = Input.GetAxis("Horizontal");
        transform.position += Vector3.up * dikey * speed * Time.deltaTime;
        transform.position += Vector3.right * yatay * speed * Time.deltaTime;

        if (transform.position.y >= 4.104424f)
        {
            transform.position = new Vector3(transform.position.x, 4.104424f, 0);

        }
        else if (transform.position.y <= -3.5)
        {
            transform.position = new Vector3(transform.position.x, -3.5f, 0);
        }

        if (transform.position.x >= 10f)
        {
            transform.position = new Vector3(-10f, transform.position.y, 0);
        }
        else if (transform.position.x <= -10f)
        {
            transform.position = new Vector3(10f, transform.position.y, 0);
        }
    }



}
