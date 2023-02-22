using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int score;
    public int health;
    public int scene;
    public float[] position;

    public PlayerData(Player player)
    {
        score=player.score;
        health=player.health;
        scene=player.scene;

        position=new float[3];

        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }



}
