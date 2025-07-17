using UnityEngine;

public class EsteLiikuvaOikea : MonoBehaviour
{
    public float movespeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * movespeed) * Time.deltaTime;
    }
}
