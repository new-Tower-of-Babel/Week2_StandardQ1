using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    public int poolSize = 300;

    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject gameObject = Instantiate(prefab);
            gameObject.SetActive(false);
            pool.Add(gameObject);
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
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
    }

    public void Release(GameObject obj)
    {
        obj.SetActive(false );
        // 게임오브젝트를 deactive한다.
    }
}
