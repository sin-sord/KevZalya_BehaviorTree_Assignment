using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ChargeAT : ActionTask {

        public BBParameter<Transform> currnetTarget;

        public float speed;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

			// Chases the player
            Vector3 directionToMoveTo = currnetTarget.value.position - agent.transform.position;
            agent.transform.position += directionToMoveTo.normalized * speed * Time.deltaTime;
			Debug.DrawLine(agent.transform.position, currnetTarget.value.position, Color.red);
            EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}