using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject prefab;

    void Awake()
    {
        Vector3 position = new Vector3(1, 1, 0);
        gameObject = Instantiate(prefab, position, Quaternion.identity) as GameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
