using UnityEngine;

public class VasenLiikkuvaSpawner : MonoBehaviour
{
    public GameObject vasenLiikkuva;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightoffset = 10;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnVasenLiikkuva();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate) {
            timer = timer + Time.deltaTime;
        } else {
            spawnVasenLiikkuva();
            timer = 0;
        }
    }


    void spawnVasenLiikkuva() 
    {
        Instantiate(vasenLiikkuva, transform.position, transform.rotation);
    }
}
