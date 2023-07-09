using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("paso Moneda");
        if (SceneManager.GetActiveScene().name == "FirstScene")
        {
            SceneManager.LoadScene("SecondScene");
        }
        else
        {
            SceneManager.LoadScene("FirstScene");
        }


    }
}
