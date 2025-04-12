using UnityEngine;

public class FinalBoss : BaseEntity
{
    public bool estaMuertoBoss = false;

    public FinalBoss(string _name, int _life, float _attack, float _defense) : base(_name, _life, _attack, _defense)
    { }
    public void ApplyBuff(string tipo, float cantidad)
    {
        Debug.Log($"Buff aplicado del tipo {tipo} y de cantidad {cantidad}");

        if (tipo == "ataque")
        {
            float NewAttack = cantidad + Attack;
            Debug.Log($"Nuevo ataque calculado: {NewAttack}");
            if (NewAttack >= 0 && NewAttack <= 100)
            {
                setAttack(NewAttack);
                Debug.Log("El ataque es: " + Attack);
            }
            else if (NewAttack > 100)
            {
                setAttack(100);
                Debug.Log("El ataque es 100");
            }
            else
            {
                setAttack(0);
                Debug.Log("El ataque es 0");
            }
        }

        if (tipo == "salud")
        {
            int NewLife = (int)cantidad + Life;
            Debug.Log($"Nueva salud calculada: {NewLife}");
            if (NewLife >= 0 && NewLife <= 200)
            {
                setLife(NewLife);
                Debug.Log("La salud es: " + Life);
            }
            else if (NewLife > 200)
            {
                setLife(200);
                Debug.Log("La salud es 200");
            }
            else
            {
                setLife(0);
                Debug.Log("La salud es 0");
            }
        }

        if (tipo == "defensa")
        {
            float NewDefense = cantidad + Defense;
            Debug.Log($"Nueva defensa calculada: {NewDefense}");
            if (NewDefense >= 0 && NewDefense <= 100)
            {
                setDefense(NewDefense);
                Debug.Log("La defensa es: " + Defense);
            }
            else if (NewDefense > 100)
            {
                setDefense(100);
                Debug.Log("La defensa es 100");
            }
            else
            {
                setDefense(0);
                Debug.Log("La defensa es 0");
            }
        }
    }


    public void VerValores()
    {
        Debug.Log("Nombre del boss: " + EntityName + ", Salud del boss: " + Life + ", Ataque del boss: " + Attack + ", Defensa del boss: " + Defense);

    }

    ~FinalBoss()
    {
        Debug.Log("El boss ha sido destruído");
    }

    public void RecibirDañoBoss(float DañoRecibido)
    {
        int NewLife = Life - (int)DañoRecibido;
        setLife(NewLife);
        if (Life <= 0)
        {
            Debug.Log($"El boss ha recibido {DañoRecibido} de daño, su nueva vida es 0");
        }
        VerificarSiBossEstaVivo();
        if (Life > 0)
        {
            Debug.Log($"El boss ha recibido {DañoRecibido} de daño, su nueva vida es {Life}");
        }
    }

    public void VerificarSiBossEstaVivo()
    {
        if (Life <= 0)
        {
            estaMuertoBoss = true;
        }
        if (estaMuertoBoss == true)
        {
            setLife(0);
            OnBossDeath();
        }
    }

    public void OnBossDeath()
    {
        Debug.Log("El boss ha muerto");
    }

}
