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
        // �����ִ� ���ӿ�����Ʈ�� ã�� active�� ���·� �����ϰ� return �Ѵ�.
    }

    public void Release(GameObject obj)
    {
        obj.SetActive(false );
        // ���ӿ�����Ʈ�� deactive�Ѵ�.
    }
}
