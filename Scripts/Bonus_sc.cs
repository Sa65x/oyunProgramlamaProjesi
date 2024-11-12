using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus_sc : MonoBehaviour
{

    public float speed = 3.0f;
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (transform.position.y < -3.22) {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player"){
            Destroy(this.gameObject);
        }
    }
}
