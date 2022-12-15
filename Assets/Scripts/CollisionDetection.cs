using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Car is damaged and cannot move further");
        TaxiController value = FindObjectOfType<TaxiController>();
        value.canMove = false;

        Invoke("ResetLevel",2f);
    }

    void ResetLevel(){
        SceneManager.LoadScene(0);
    }
}
