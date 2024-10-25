using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Quest Data", menuName = "SO/Quest Data",order =int.MinValue)]
public class QuestDataSO : ScriptableObject
{
    [SerializeField] private string QuestName;//퀘스트의이름
    [SerializeField] private int QuestRequiredLevel;//퀘스트의 최소레밸
    [SerializeField] private int QuestNPC;//퀘스트를 주는 NPC의 ID
    [SerializeField] private List<int> QuestPrerequisites; //선행퀘스트들 id들의 리스트
}
