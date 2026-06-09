using UnityEngine;
using UnityEngine.AI; // Нужно для работы с NavMesh

[RequireComponent(typeof(NavMeshAgent))]
public class NavMeshMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private Camera mainCamera;

    void Start()
    {
        // Получаем компонент NavMeshAgent на объекте
        agent = GetComponent<NavMeshAgent>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Проверяем нажатие левой кнопки мыши
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Пускаем луч из камеры в точку клика
            if (Physics.Raycast(ray, out hit))
            {
                // Задаем агенту цель перемещения
                agent.SetDestination(hit.point);
            }
        }
    }
}
