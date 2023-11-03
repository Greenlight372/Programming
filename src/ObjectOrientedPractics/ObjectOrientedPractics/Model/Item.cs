using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий товар в магазине.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Счетчик.
        /// </summary>
        static private int _idCounter = 0;
        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        readonly int _id;
        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;
        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;
        /// <summary>
        /// Цена товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Получает уникальный идентификатор товара.
        /// </summary>
        public int GetId { get => _id; }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }
        
        /// <summary>
        /// Получает и заполняет название товара.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Получает и заполняет информацию о товаре.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Получает и заполняет цену товара.
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                if (value < 0 || value > 100000)
                    throw new ArgumentException($"Цена товара должна быть от 0 до 100000 руб.");
                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр объекта класса <see cref="Item"></see>.
        /// </summary>
        /// <param name="category">Категория товара.</param>>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Информация о товаре.</param>
        /// <param name="cost">Цена товара.</param>
        public Item(string name, string info, double cost)
        {
            _id = _idCounter++;
            Name = name;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Выделяет память под объект класса <see cref="Item"></see>.
        /// </summary>
        public Item()
        {
        }
    }
}
