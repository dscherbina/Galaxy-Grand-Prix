using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class RocketShoot : MonoBehaviour
{
    [SerializeField] public GameObject Rocket;
    [SerializeField] public GameObject Enemy;
    [SerializeField] public GameObject Explosion;
    [SerializeField] public AudioSource RocketSound;
    [SerializeField] public AudioSource ExplosionSound;
    public float speed = 15f;
    private void Awake()
    {
        RocketSound.Play();
    }
    
    void FixedUpdate()
    {
        StartCoroutine(Shoot());
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            StartCoroutine(Boom());
        }
    }
    IEnumerator Shoot()
    {
        Rocket.SetActive(true);
        yield return new WaitForSeconds(1);
        transform.position = Vector3.MoveTowards(transform.position, Enemy.transform.position, speed * Time.deltaTime);
        transform.up = Enemy.transform.position - transform.position;
    }
    IEnumerator Boom()
    {
        RocketSound.Stop();
        yield return new WaitForSeconds(0);
        Explosion.SetActive(true);
        ExplosionSound.Play();
        GameObject.Find("Rocket Variant").GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(2f);
        Destroy(Rocket);
    }
}
