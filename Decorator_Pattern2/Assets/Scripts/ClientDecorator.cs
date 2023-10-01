using UnityEngine;

namespace Chapter.Decorator
{
    public class ClientDecorator : MonoBehaviour
    {
        //private DecoratorPattern _hotDog;
        //private bool _isAvoocadoToastDecorated;
        private bool _bacon;
        private bool _tomato;
        private bool _eggs;
        public GameObject bacon;
        public GameObject tomato;
        public GameObject eggs;

        /*void Start()
        {
            _hotDog =
                (DecoratorPattern)
                FindObjectOfType(typeof(DecoratorPattern));
        }*/

        void OnGUI()
        {
            if (/*!_isAvoocadoToastDecorated &&*/ !_bacon)
                if (GUILayout.Button("Add Bacon"))
                {
                    // _bikeWeapon.Decorate();
                    //_isAvoocadoToastDecorated = !_isAvoocadoToastDecorated;
                    _bacon = !_bacon;
                    bacon.SetActive(true);
                }

            if (/*_isAvoocadoToastDecorated &&*/ _bacon)
                if (GUILayout.Button("Remove Bacon"))
                {
                    // _bikeWeapon.Reset();
                   // _isAvoocadoToastDecorated = !_isAvoocadoToastDecorated;
                    _bacon = !_bacon;
                    bacon.SetActive(false);
                }

            if (/*!_isAvoocadoToastDecorated &&*/ !_tomato) 
                if (GUILayout.Button("Add Tomatoes"))
                {
                    // _bikeWeapon.Decorate();
                    //_isAvoocadoToastDecorated = !_isAvoocadoToastDecorated;
                    _tomato = !_tomato;
                    tomato.SetActive(true);
                }

            if (/*_isAvoocadoToastDecorated &&*/ _tomato)
                if (GUILayout.Button("Remove Tomatoes"))
                {
                    // _bikeWeapon.Reset();
                   // _isAvoocadoToastDecorated = !_isAvoocadoToastDecorated;
                    _tomato = !_tomato;
                    tomato.SetActive(false);
                }

            if (/*!_isAvoocadoToastDecorated &&*/ !_eggs)
                if (GUILayout.Button("Add Eggs"))
                {
                    // _bikeWeapon.Decorate();
                   // _isAvoocadoToastDecorated = !_isAvoocadoToastDecorated;
                    _eggs = !_eggs;
                    eggs.SetActive(true);
                }

            if (/*_isAvoocadoToastDecorated &&*/ _eggs)
                if (GUILayout.Button("Remove Eggs"))
                {
                    // _bikeWeapon.Reset();
                    //_isAvoocadoToastDecorated = !_isAvoocadoToastDecorated;
                    _eggs = !_eggs;
                    eggs.SetActive(false);
                }



            /*if (GUILayout.Button("Toggle Fire"))
                _bikeWeapon.ToggleFire(); */
        }
    }
}