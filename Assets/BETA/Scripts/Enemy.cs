using UnityEngine;

namespace BETA7
{
    public class Enemy : MonoBehaviour
    {
        public float speed;
        private GameObject Player;
        public GameObject objBullet;
        public Transform BulletPoint;
        public float delay = 0.5f;
        public float fireRate = 1.0f;

        public float hp = 1.0f;
        public float maxHp = 1.0f;
        Rigidbody thisRigi;


        void Start()
        {
            this.GetComponent<Rigidbody>().linearVelocity = transform.forward * speed;
            InvokeRepeating("fireBullet", delay, fireRate);
        }

        // Update is called once per frame
        void Update()
        {
            fireBullet();
        }

        void fireBullet()
        {
            if (Player != null)
            {
                GameObject bullet = Instantiate(
                    objBullet, BulletPoint.transform.position, this.transform.rotation);
                bullet.GetComponent<Bullet>().SetBullet(Player.transform.position);
            }
        }

        void Move()
        {
            if(Player != null)
            {
                thisRigi.linearVelocity = (Player.transform.position - transform.position).normalized * speed;
            }
        }
    }
}
