using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Status
{
    NoEffect,
    Healthy,
    Stunned,
    Poisoned = 15 //THIS WILL BE THE STANDARD POISON DAMAGE
                  //DoubleHeal?
}
public enum DefendState
{
    Physical,
    Magical,
    Ultimate,
    Healing,
}
public class BattleAction
{
    private int m_MoveValue;
    private int m_ManaValue;
    private string m_MoveName;
    private Status m_Effect;
    private DefendState m_ActionType;

    //get set properties for all important variables
    public int M_MoveValue { get { return m_MoveValue; } }
    public int M_ManaValue { get { return m_ManaValue; } }
    public string M_MoveName { get { return m_MoveName; } }
    public Status M_Effect { get { return m_Effect; } }
    public DefendState M_ActionType { get { return m_ActionType; } }
    //get set properties for all important variables

    public BattleAction(string movename, int movevalue, int manavalue, Status effect, DefendState actiontype)
    {
        m_MoveValue = movevalue;
        m_ManaValue = manavalue;
        m_MoveName = movename;
        m_Effect = effect;
        m_ActionType = actiontype;
    }
}

public class BattleOption : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
