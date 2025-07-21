using UnityEngine;

public class OikeaLiikkuvaSpawner : MonoBehaviour
{
    public GameObject liikkuvaOikea;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightoffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnLiikkuvaoikea();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate) {
            timer = timer + Time.deltaTime;
        } else {
            spawnLiikkuvaoikea();
            timer = 0;
        }
    }
    void spawnLiikkuvaoikea() 
        { Instantiate(liikkuvaOikea, transform.position, transform.rotation); }


}
