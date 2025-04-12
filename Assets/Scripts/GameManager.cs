using System;
using UnityEngine;
using UnityEditor;


public class GameManager : MonoBehaviour
{
    private int option;
    private int option2;


    void Start()
    {
        FinalBoss Bossfinal = new FinalBoss("Bossaso", 100, 70, 50);
        Bossfinal.VerValores();

        Player player1 = new Player("player1", 100, 70, 50);
        player1.VerValores();

        for (int i = 0; i < 4; i++)
        {
            option = (int)UnityEngine.Random.Range(1, 4);
            switch (option)
            {
                case 1:
                    Bossfinal.ApplyBuff("ataque", (float)UnityEngine.Random.Range(-10, 11));
                    break;
                case 2:
                    Bossfinal.ApplyBuff("salud", (float)UnityEngine.Random.Range(-10, 11));
                    break;
                case 3:
                    Bossfinal.ApplyBuff("defensa", (float)UnityEngine.Random.Range(-10, 11));
                    break;
            }
        }

        while (player1.estaMuertoPlayer == false && Bossfinal.estaMuertoBoss == false)
        {
            option2 = (int)UnityEngine.Random.Range(1, 3);
            switch (option2)
            {
                case 1:
                    Bossfinal.RecibirDañoBoss((float)UnityEngine.Random.Range(1, 11));
                    break;
                case 2:
                    player1.RecibirDañoPlayer((float)UnityEngine.Random.Range(1, 11));
                    break;
            }
        }
        
    }

}
