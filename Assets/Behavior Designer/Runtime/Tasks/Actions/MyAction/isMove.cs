using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using  System;
[TaskCategory("MyConditionals")]
[TaskDescription("判断对象是否移动")]
public class isMove : Conditional
{

    [BehaviorDesigner.Runtime.Tasks.Tooltip("上一次的位置")]
    public Vector3 lastPosition;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("判断的对象")]
    public SharedGameObject obj;

    public override TaskStatus OnUpdate()
    {

        if (Vector3.Distance(obj.Value.transform.position , lastPosition)<1)
        {

            return TaskStatus.Failure;
        }
        lastPosition = obj.Value.transform.position;
        return TaskStatus.Success;
    }
}