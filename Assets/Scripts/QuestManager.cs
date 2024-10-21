using UnityEngine;
public class QuestManager : MonoBehaviour
{
    // [�������� 1] ���� �ʵ� ����
    private static QuestManager instance;
    // [�������� 2] ���� ������Ƽ ����
    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>();
                if (instance==null)
                {
                    GameObject instanceGameObject = new GameObject();
                    instance = instanceGameObject.AddComponent<QuestManager>();
                }
            }
            return instance;
        }
    }
    // [�������� 3] �ν��Ͻ� �˻� ����
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}