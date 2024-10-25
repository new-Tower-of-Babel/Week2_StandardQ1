using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Quest Data", menuName = "SO/Quest Data",order =int.MinValue)]
public class QuestDataSO : ScriptableObject
{
    [SerializeField] private string QuestName;//����Ʈ���̸�
    [SerializeField] private int QuestRequiredLevel;//����Ʈ�� �ּҷ���
    [SerializeField] private int QuestNPC;//����Ʈ�� �ִ� NPC�� ID
    [SerializeField] private List<int> QuestPrerequisites; //��������Ʈ�� id���� ����Ʈ
}
