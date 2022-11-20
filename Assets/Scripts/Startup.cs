using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour
{
    public List<GameObject> startupPrefabs = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        GameObject bg = startupPrefabs[0];
        
    }


    void Instantialization(GameObject bg)
    {
        Instantiate(bg, transform.position, Quaternion.identity);
    }
}
