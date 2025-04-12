using UnityEngine;

public class Player : BaseEntity
{
    public bool estaMuertoPlayer = false;
    public Player(string _name, int _life, float _attack, float _defense) : base(_name, _life, _attack, _defense)
    { }

    public void VerValores()
    {
        Debug.Log("Nombre del Player: " + EntityName + ", Salud del Player: " + Life + ", Ataque del Player: " + Attack + ", Defensa del Player: " + Defense);

    }

    public void RecibirDa�oPlayer(float Da�oRecibido)
    {
        int NewLife = Life - (int)Da�oRecibido;
        setLife(NewLife);
        if (Life <= 0)
        {
            Debug.Log($"El Player ha recibido {Da�oRecibido} de da�o, su nueva vida es 0");
        }
        VerificarSiPlayerEstaVivo();
        if (Life > 0)
        {
            Debug.Log($"El Player ha recibido {Da�oRecibido} de da�o, su nueva vida es {Life}");
        }
    }

    public void VerificarSiPlayerEstaVivo()
    {
        if (Life <= 0)
        {
            estaMuertoPlayer = true;
        }
        if (estaMuertoPlayer == true)
        {
            setLife(0);
            OnPlayerDeath();
        }
    }

    public void OnPlayerDeath()
    {
        Debug.Log("El Player ha muerto");
    }

    ~Player()
    {
        Debug.Log("El Player ha sido destru�do");
    }

}
