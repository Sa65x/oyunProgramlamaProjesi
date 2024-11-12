/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_sc : MonoBehaviour
{

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime);

        if (transform.position.y > 7.2f)
        {
            Destroy(this.gameObject);
        }
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_sc : MonoBehaviour
{
    public float speed = 10f ;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        if (transform.position.y > 7.2f)
        {
            Destroy(this.gameObject);
        }
    }
}
