float momenteleSnelheid = 15 000 000;
float rotatiesRondDeAarde;
Vector3 startPos;
public Transform bovensteCapsule;
void Awake()
{
	Draai(bovensteCapsule);
	startPos = transform.position;
}
void Update()
{
	bovensteCapsule.Rotate(Vector3.up * momenteleSnelheid * Time.deltaTime);
               if((transform.position-startPos).sqrMagnitude > 6371 / 2)
		rotatiesRondDeAarde++;
}
