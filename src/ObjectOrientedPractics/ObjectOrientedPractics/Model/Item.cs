using ObjectOrientedPractics.Model.Enums;
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
    public class Item : ICloneable
    {
        /// <summary>
        /// Передает информацию об изменении
        /// названия товара.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;
        /// <summary>
        /// Передает информацию об изменении
        /// стоимости товара.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;
        /// <summary>
        /// Передает информацию об изменении
        /// информации о товаре.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;

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
                var args = new EventArgs();
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                if (_name != value)
                    NameChanged?.Invoke(this, args);
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
                var args = new EventArgs();
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                if (_info != value)
                    InfoChanged?.Invoke(this, args);
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
                var args = new EventArgs();
                if (value < 0 || value > 100000)
                    throw new ArgumentException($"Цена товара должна быть от 0 до 100000 руб.");
                if (_cost != value)
                    CostChanged?.Invoke(this, args);
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

        /// <inheritdoc />
        public object Clone()
        {
            return new Item(this.Name, this.Info, this.Cost);
        }

        /// <inheritdoc />
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            if (!(other is Item))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            var item2 = (Item)other;

            return (this.Name == item2.Name);
        }

        /// <inheritdoc cref="IComparable.CompareTo(object?)"/>
        public int CompareTo(object other)
        {
            var item2 = (Item)other;

            if (this.Cost == item2.Cost)
            {
                return 0;
            }
            else if (this.Cost > item2.Cost)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
