using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Encounter Quest Data", menuName = "SO/Encounter Quest Data", order = int.MinValue)]
public class EncounterQuestDataSO : QuestDataSO
{
    [SerializeField] private string npcName;
}