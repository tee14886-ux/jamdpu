using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

    private void Start()
    {
        float x = Random.Range(-19, 16);
        float y = Random.Range(-23, 18);
        transform.position = new Vector3(x, 0.5f, y);
    }
    public void MyRandoml()
    {
        float x = Random.Range(-19, 16);
        float y = Random.Range(-23, 18);
        transform.position = new Vector3(x, 0.5f, y);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene(0);
            MyRandoml();
        }
    }
}
