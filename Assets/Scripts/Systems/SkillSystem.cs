using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSystem : MonoBehaviour
{
    List<ISkill> HeroSkill;
    //Ӣ�ۼ��ܶ����б�
    List<ISkill> EquipmentSkill;
    //װ�����ܶ����б�
    private Individual individual;
    // Start is called before the first frame update
    void Start()
    {
        individual = GetComponent<Individual>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReceiveMessage(Individual attacker,float de)
    {
        foreach (var skill in HeroSkill)
        {
            skill.DealAttackMessage(attacker, de);
        }
        foreach (var skill in EquipmentSkill)
        {
            skill.DealAttackMessage(attacker, de);
        }
    }
}
