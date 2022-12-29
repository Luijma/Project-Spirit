using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit
{
    protected string m_uID;
    protected string m_Name;

    protected Unit(string uID, string name)
    {
        m_uID = uID;
        m_Name = name;
    }

    public string Name
    {
        get { return m_Name; }
        set { m_Name = value; }
    }


    // Start is called before the first frame update
}
public abstract class BattleUnit : Unit
{
    protected int m_MaxHP;
    protected int m_MaxMP;
    protected int m_CurrentHP;
    protected int m_CurrentMP;

    protected Status m_CurrentStatus;
    protected DefendState m_BlockType;

    protected int characterIconIndex;

    public Status CurrentStatus
    { get; set; }

    public DefendState BlockType
    { get; set; }

    protected BattleAction[] m_Physical = new BattleAction[4];
    protected BattleAction[] m_Magical = new BattleAction[4];
    protected BattleAction[] m_Support = new BattleAction[4];
    protected BattleAction[] m_Ultimate = new BattleAction[1];

    public int CurrentHP
    {
        get => m_CurrentHP;
        set
        {
            if ((m_CurrentHP + value) < 0)
            {
                m_CurrentHP = 0;
            }
            else if ((m_CurrentHP + value) > m_MaxHP)
            {
                m_CurrentHP = m_MaxHP;
            }
            else
            {
                m_CurrentHP = value;
            }
        }
    }
    public int CurrentMP
    {
        get => m_CurrentMP;
        set
        {
            if ((m_CurrentMP + value) < 0)
            {
                m_CurrentMP = 0;
            }
            else if ((m_CurrentMP + value) > m_MaxMP)
            {
                m_CurrentMP = m_MaxMP;
            }
            else
            {
                m_CurrentMP = value;
            }
        }
    }
    protected BattleUnit(string uID, string name, int maxHP, int maxMP, int currentHP, int currentMP, Status status = Status.NoEffect, DefendState defendState = DefendState.Physical) : base(uID, name)
    {
        m_uID = uID;
        m_Name = name;
        m_MaxHP = maxHP;
        m_MaxMP = maxMP;
        m_CurrentHP = currentHP;
        m_CurrentMP = currentMP;

        m_CurrentStatus = status;
        m_BlockType = defendState;
    }
}
