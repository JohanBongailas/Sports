using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startup : MonoBehaviour
{
    // Create a list of startup prefabs to be Instantiated
    public List<GameObject> startupPrefabs = new List<GameObject>();
    

    void Start()
    {
        setProperties(startupPrefabs);
        Instantialize(startupPrefabs);
    }

    void setProperties(List<GameObject> startupPrefabs)
    {
        // Active status
        foreach (var gameObj in startupPrefabs)
        {
            gameObj.SetActive(true);
        }
        
    }

    void Instantialize(List<GameObject> startupPrefabs)
    {
        foreach (var gameObj in startupPrefabs)
        {
            Instantiate(gameObj);
        }
    }
}
