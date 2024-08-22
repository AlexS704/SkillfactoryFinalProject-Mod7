//Основной класс
//Класс для представления индивидуального клиента, который делает заказ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Частный клиент
    public class IndividualClient
    {
        private string _name;
        private string _surname;
        private int _age;

        public IndividualClient(string name, string surname, int age)
        {

            _name = name;
            _surname = surname;

            if (age < 18)
            {
                Console.WriteLine("Вам еще нет 18 лет. Вы не можете оформить доставку!");
            }
            else
            {
                _age = age;
            }
        }

        

    }
}
