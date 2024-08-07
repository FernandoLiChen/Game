using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DungeonGenerationData", menuName = "DungeonGenerationData/Dungeon Data")]
public class DungeonGenerationData : ScriptableObject
{
    public int numberOfCrawlers;
    public int iterationMin;
    public int iterationMax;
}
