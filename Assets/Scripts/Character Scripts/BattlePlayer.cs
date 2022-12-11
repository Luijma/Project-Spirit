using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayer : BattleUnit
{
    protected BattlePlayer(string uiD, string name, int maxHP, int maxMP, int currentHP, int currentMP) : base (uiD, name, maxHP, maxMP, currentHP, currentMP)
    {
        //negative number on movevalue means move deals damage.
        //positive number on movevalue means move heals damage.
        //Same concept for manavalue.
        m_Physical[0] = new BattleAction("Cross Slash", -35, 40, Status.NoEffect, DefendState.Physical);
        m_Physical[1] = new BattleAction("Spirit Drain", -25, 50, Status.NoEffect, DefendState.Physical);
        m_Physical[2] = new BattleAction("Grass Roots", -30, 38, Status.NoEffect, DefendState.Physical);
        m_Physical[3] = new BattleAction("Drain", -35, 25, Status.NoEffect, DefendState.Physical);

        m_Magical[0] = new BattleAction("Explosive poison bomb", -15, -45, Status.Poisoned, DefendState.Magical);
        m_Magical[1] = new BattleAction("Icy blizzard", -25, 50, Status.Stunned, DefendState.Magical);
        m_Magical[2] = new BattleAction("Windy tornado", -90, -115, Status.NoEffect, DefendState.Magical);
        m_Magical[3] = new BattleAction("Watery tearfest", -60, -50, Status.NoEffect, DefendState.Magical);

        m_Support[0] = new BattleAction("Grandma's Recipe", 125, -75, Status.NoEffect, DefendState.Healing);
        m_Support[1] = new BattleAction("Basil Buffet", 45, -85, Status.Healthy, DefendState.Healing);
        m_Support[2] = new BattleAction("Aura Cleansing", 75, -40, Status.NoEffect, DefendState.Healing);
        m_Support[3] = new BattleAction("Solar Winds", 45, -30, Status.NoEffect, DefendState.Healing);

        m_Ultimate[0] = new BattleAction("Ultimate", 200, -150, Status.NoEffect, DefendState.Ultimate);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
