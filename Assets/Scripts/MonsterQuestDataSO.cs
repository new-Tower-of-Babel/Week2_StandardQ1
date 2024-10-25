using UnityEngine;

[CreateAssetMenu(fileName = "Monster Quest Data", menuName = "SO/Monster Quest Data", order = int.MinValue)]
public class MonsterQuestDataSO : QuestDataSO
{
    [SerializeField] private string monsterName;
    [SerializeField] private string monsterCount;
}
