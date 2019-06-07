using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSystem : MonoBehaviour
{
    List<ISkill> heroSkills = new List<ISkill>();
    //Ӣ�ۼ��ܶ����б�
    // List<ISkill> EquipmentSkill = new List<ISkill>();
    //װ�����ܶ����б�
    private Individual individual;
    // Start is called before the first frame update
    void Start()
    {
        individual = GetComponent<Individual>();
        
        heroSkills.Add(new AOESkill(0,0.1f));
        heroSkills.Add(new AOESkill(1,0.1f));
        heroSkills.Add(new AOESkill(2,0.1f));
    }

    // Update is called once per frame
    void Update()
    {
        foreach(ISkill skill in heroSkills)
        {
            skill.UpdateSkill(individual);
        }
    }

    /// <summary>
    /// �ͷż���
    /// </summary>
    /// <param name="index"></param>
    public void ReleaseSkill(int index)
    {
        Logger.Log("Release Skill " + index , LogType.Skill);

        if(index >= heroSkills.Count){ return; }

        heroSkills[index].ReleaseSkill(individual);
    }

    public void ReceiveMessage(Individual attacker,float damage)
    {
        //Ϊ������ԣ���ʱʲôҲ����
        //foreach (var skill in HeroSkill)
        //{
        //    skill.DealAttackMessage(attacker, damage);
        //}
        //foreach (var skill in EquipmentSkill)
        //{
        //    skill.DealAttackMessage(attacker, damage);
        //}
    }
}
