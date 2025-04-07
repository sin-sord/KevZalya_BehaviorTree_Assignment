using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ShootAT : ActionTask {

		public GameObject bullet;
		public GameObject player;
		GameObject spawned;
		public Transform bulletSpawnPosition;
		public Vector3 playerPosition;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}


		protected override void OnExecute() {

			Debug.Log("shot");

			//On this line, we're creating an instance of the bullet prefab
			//We're storing a reference to the spawned gameobject in "spawned" (the GameObject variable on this script)
			spawned = GameObject.Instantiate(bullet, bulletSpawnPosition.transform.position, Quaternion.identity);

			//We're pulling the bulletMovement script off of the spawned bullet
            bulletMovement bulletTest = spawned.GetComponent<bulletMovement>();

			//Setting the player's position on the bulletMovement script so that it can move in the direction of the player
			bulletTest.player = player.transform.position;
            Debug.DrawLine(agent.transform.position, player.transform.position, Color.red);
			

			//bullet.transform.position = playerPosition;

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