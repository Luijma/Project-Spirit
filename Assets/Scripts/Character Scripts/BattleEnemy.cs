using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleEnemy : BattleUnit
{
    protected BattleEnemy(string uiD, string name, int maxHP, int maxMP, int currentHP, int currentMP) : base(uiD, name, maxHP, maxMP, currentHP, currentMP)
    {
        m_Physical[0] = new BattleAction("Absorb", -35, 40, Status.NoEffect, DefendState.Physical);
        m_Physical[1] = new BattleAction("Leachify", -25, 50, Status.NoEffect, DefendState.Physical);
        m_Physical[2] = new BattleAction("Dig deep", -30, 38, Status.NoEffect, DefendState.Physical);
        m_Physical[3] = new BattleAction("Timber", -35, 25, Status.NoEffect, DefendState.Physical);

        m_Magical[0] = new BattleAction("Foggy Mist", -45, -35, Status.NoEffect, DefendState.Magical);
        m_Magical[1] = new BattleAction("Ivy Tornado", -15, -75, Status.Poisoned, DefendState.Magical);
        m_Magical[2] = new BattleAction("Malicious vines", -55, -90, Status.Stunned, DefendState.Magical);
        m_Magical[3] = new BattleAction("Sappy surprise", -75, -125, Status.NoEffect, DefendState.Magical);

        m_Support[0] = new BattleAction("Synthesis", 55, -90, Status.NoEffect, DefendState.Magical);
        m_Support[1] = new BattleAction("Himarra's remedy", 35, -100, Status.Healthy, DefendState.Healing);
        m_Support[2] = new BattleAction("HotSpring", 100, -130, Status.NoEffect, DefendState.Healing);
        m_Support[3] = new BattleAction("Stanley Steamer", 30, -35, Status.NoEffect, DefendState.Healing);

        m_Ultimate[0] = new BattleAction("Earth shaking quake", -100, -175, Status.Poisoned, DefendState.Ultimate);

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
