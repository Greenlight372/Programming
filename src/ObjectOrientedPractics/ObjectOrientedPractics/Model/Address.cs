using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий адрес клиента магазина.
    /// </summary>
    public class Address : ICloneable
    {
        /// <summary>
        /// Передает информацию об изменении полей
        /// объекта
        /// </summary>
        public event EventHandler<EventArgs> AddressChanged;
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private string _index;
        /// <summary>
        /// Страна проживания.
        /// </summary>
        private string _country;
        /// <summary>
        /// Город.
        /// </summary>
        private string _city;
        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;
        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;
        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Получает и заполняет почтовый индекс.
        /// </summary>
        public string Index
        {
            get => _index;
            set
            {
                ValueValidator.AssertStringOnLength(value, 6, 6, nameof(Index));
                string oldIndex = _index;
                _index = value;
                if (_index != oldIndex)
                    AddressChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Получает и заполняет страну проживания.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                string oldCountry = _country;
                _country = value;
                if (_country != oldCountry)
                    AddressChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Получает и заполняет город.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                string oldCity = _city;
                _city = value;
                if (_index != oldCity)
                    AddressChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Получает и заполняет улицу.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                string oldStreet = _street;
                _street = value;
                if (_street != oldStreet)
                    AddressChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Получает и заполняет номер дома.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                string oldBuilding = _building;
                _building = value;
                if (_building != oldBuilding)
                    AddressChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Получает и заполняет номер квартиры/помещения.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                string oldApartment = _apartment;
                _apartment = value;
                if (_apartment != oldApartment)
                    AddressChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Конструктор класса по умолчанию.
        /// </summary>
        public Address()
        {
            Index = "000000";
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Создает экземпляр объекта класса <see cref="Address"></see>.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры/помещения.</param>
        public Address(string index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <inheritdoc />
        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment);
        }

        /// <inheritdoc />
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            if (!(other is Address))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            var address2 = (Address)other;

            return (this.Index == address2.Index);
        }
    }
}
