using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private GameObject _spawnPoint;
    [SerializeField] private int _jumpForce;
    [SerializeField] private TMP_Text _text;
    private int _points;
    private bool _isGrounded;
    private float _timer;
    
    
   
    
    // Start is called before the first frame update
    void Start()
    {
        _timer = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            //Make jump here
            _isGrounded = false;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }

        
        
        if (_timer <= 0)
        {
            
            Instantiate(_coinPrefab, _spawnPoint.transform.position, _spawnPoint.transform.rotation);
            _timer = Random.Range(1, 4);
        }
        

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGrounded = true;
        }
        else
        {
            Debug.Log("Touching coin");
            _points++;
            collision.gameObject.SetActive(false);
        }
    }
}
