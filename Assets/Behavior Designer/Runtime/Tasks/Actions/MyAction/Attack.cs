using UnityEngine;
using UnityEngine.AI;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

[TaskCategory("MyActions")]
[TaskDescription("攻击玩家")]
public class Attack : Action
{
    [BehaviorDesigner.Runtime.Tasks.Tooltip("攻击距离")]
    public float ranage;
    [BehaviorDesigner.Runtime.Tasks.Tooltip("攻击目标玩家")]
    public SharedGameObject player;
    [BehaviorDesigner.Runtime.Tasks.Tooltip("自己")]
    public SharedGameObject monster;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("动画器")]
    public Animator animator;
    [BehaviorDesigner.Runtime.Tasks.Tooltip("当前动画状态")]
    public AnimatorStateInfo info;
    public override TaskStatus OnUpdate()
    {
        monster.Value.GetComponent<NavMeshAgent>().isStopped=true;
        info = animator.GetCurrentAnimatorStateInfo(0);
        if (info.IsName("Attack")&&info.normalizedTime<0.5 && info.normalizedTime > 0.3)
        {
            if(Vector3.Distance(player.Value.transform.position, monster.Value.transform.position) < ranage)
                player.Value.GetComponent<Player>().OnDamage(1);
        }
                return TaskStatus.Success;
    }
}