using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public Rigidbody rb; 
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "start");
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message: "update");
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        UnityEngine.Vector3 direcao = new Vector3(x, y: 0, z: 0);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
        if (transform.position.y < -5);
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
