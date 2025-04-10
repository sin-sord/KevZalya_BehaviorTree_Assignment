using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class TargetInRangeCT : ConditionTask {

		public BBParameter<Transform> currentTarget;
		public float radius;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		protected override bool OnCheck() {

			float distanceToTarget = Vector3.Distance(agent.transform.position, currentTarget.value.position);
			agent.transform.LookAt(currentTarget.value.position);
			
			return distanceToTarget < radius;
		}
	}
}