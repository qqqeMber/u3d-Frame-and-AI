using UnityEngine.AI;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

[TaskCategory("MyActions")]
[TaskDescription("移动至漫游点")]
public class MoveToWanderPoint : Action
{

    [BehaviorDesigner.Runtime.Tasks.Tooltip("移动的速度")]
    public float speed = 1;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("移动的目标点")]
    public SharedVector3 position;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("自己")]
    public SharedGameObject monster;
    public override TaskStatus OnUpdate()
    {
        monster.Value.GetComponent<NavMeshAgent>().speed = speed;
        monster.Value.GetComponent<NavMeshAgent>().SetDestination(position.Value);
        return TaskStatus.Success;
    }
}