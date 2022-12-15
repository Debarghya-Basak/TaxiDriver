using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOffCustomer : MonoBehaviour
{
    bool hasCustomerInCar = false;
    bool customer1 = false;
    bool customer2 = false;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Customer 1" && hasCustomerInCar == false){
            Debug.Log("Customer has been picked up");
            hasCustomerInCar = true;
            customer1 = true;
            Destroy(other.gameObject);
        }
        else if(other.tag == "Customer 2" && hasCustomerInCar == false){
            Debug.Log("Customer has been picked up");
            hasCustomerInCar = true;
            customer2 = true;
            Destroy(other.gameObject);
        }
        else if(other.tag == "DropLocation 1" && hasCustomerInCar == true && customer1 == true){
             Debug.Log("Customer has been dropped");
             hasCustomerInCar = false;
             customer1 = false;
             Destroy(other.gameObject);
        }
        else if(other.tag == "DropLocation 2" && hasCustomerInCar == true && customer2 == true){
             Debug.Log("Customer has been dropped");
             hasCustomerInCar = false;
             customer2 = false;
             Destroy(other.gameObject);
        }
    }

}
