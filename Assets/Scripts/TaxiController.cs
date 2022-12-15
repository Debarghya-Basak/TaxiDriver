using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiController : MonoBehaviour
{

    [SerializeField] float carSpeed = 10f;

    public float CarSpeed { get => carSpeed; set => carSpeed = value; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //forward, backward and Steering controls-------------------------------------------------------
        transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * carSpeed * Time.deltaTime, 0));

        if(Input.GetAxis("Vertical") != 0){
            transform.Rotate(new Vector3(0, 0, - (Input.GetAxis("Horizontal") * Input.GetAxis("Vertical")))); 
        }
        //forward, backward and Steering controls END---------------------------------------------------
    }
}
