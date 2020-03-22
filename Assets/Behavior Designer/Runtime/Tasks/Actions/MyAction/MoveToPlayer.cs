using UnityEngine.AI;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

[TaskCategory("MyActions")]
[TaskDescription("移动至玩家")]
public class MoveToPlayer : Action
{

    [BehaviorDesigner.Runtime.Tasks.Tooltip("移动的速度")]
    public float speed = 5;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("移动的目标玩家")]
    public SharedGameObject player;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("自己")]
    public SharedGameObject monster;

    public override TaskStatus OnUpdate()
    {
        monster.Value.GetComponent<NavMeshAgent>().isStopped = false;
        monster.Value.GetComponent<NavMeshAgent>().speed = speed;
        monster.Value.GetComponent<NavMeshAgent>().SetDestination(player.Value.transform.position);
        return TaskStatus.Success;
    }
}