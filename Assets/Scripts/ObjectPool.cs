using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    public int poolSize = 300;

    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }
    public GameObject Get()
    {
        foreach (GameObject go in pool)
        {
            if (!go.activeInHierarchy)
            {
                return go;
            }
        }
        GameObject gameObject = Instantiate(prefab);
        gameObject.SetActive(false );
        pool.Add(gameObject);
        return gameObject;
    }

    public void Release(GameObject obj)
    {
        obj.SetActive(false );
    }
}
