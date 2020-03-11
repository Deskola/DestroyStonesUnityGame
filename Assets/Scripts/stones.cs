using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stones : MonoBehaviour
{
    public GameObject explosion;
    private const float yDie = -30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yDie)
            Destroy(gameObject);
        
    }

    private void OnMouseDown()
    {
        Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 2.0f);
        Destroy(gameObject);

        GameManager.currentNumberStonesDestroyed++;
    }
}
