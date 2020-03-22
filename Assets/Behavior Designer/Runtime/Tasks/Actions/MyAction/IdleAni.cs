using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

[TaskCategory("MyActions")]
[TaskDescription("播放idle")]
public class IdleAni : Action
{
    [BehaviorDesigner.Runtime.Tasks.Tooltip("动画器")]
    public Animator animator;
    [BehaviorDesigner.Runtime.Tasks.Tooltip("当前动画状态")]
    public AnimatorStateInfo info;
    public override TaskStatus OnUpdate()
    {
        info = animator.GetCurrentAnimatorStateInfo(0);
        if(info.IsName("Attack"))
        {
            animator.SetBool("isATTACK", false);
        }
        if (info.IsName("Walk"))
        {
            animator.SetBool("isWALK", false);
        }
        else if (info.IsName("Run"))
        {
            animator.SetBool("isRUN", false);
        }
        animator.SetBool("isIDLE", true);
        return TaskStatus.Success;
    }
}
