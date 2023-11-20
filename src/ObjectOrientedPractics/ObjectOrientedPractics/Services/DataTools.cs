using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Служебный класс для работы с делегатами.
    /// </summary>
    static public class DataTools
    {
        /// <summary>
        /// Сортировка товаров по возрастанию (цена).
        /// </summary>
        /// <param name="item1">Первый товар.</param>
        /// <param name="item2">Второй товар.</param>
        /// <returns>Логическое выражение.</returns>
        static public bool SortByAscending(Item item1, Item item2)
        {
            return item2.Cost <= item1.Cost;
        }

        /// <summary>
        /// Сортировка товаров по убыванию (цена).
        /// </summary>
        /// <param name="item1">Первый товар.</param>
        /// <param name="item2">Второй товар.</param>
        /// <returns>Логическое выражение.</returns>
        static public bool SortByDescending(Item item1, Item item2)
        {
            return item2.Cost >= item1.Cost;
        }

        /// <summary>
        /// Сортировка товаров по названию в
        /// алфавитном порядке.
        /// </summary>
        /// <param name="item1">Первый товар.</param>
        /// <param name="item2">Второй товар.</param>
        /// <returns>Логическое выражение.</returns>
        static public bool SortByName(Item item1, Item item2)
        {
            if (String.Compare(item1.Name, item2.Name) >= 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Сравнивает стоимость товара с фиксированным
        /// значение.
        /// </summary>
        /// <param name="item">Товарный объект.</param>
        /// <returns>Логическое выражение.</returns>
        static public bool CompareCost(Item item)
        {
            return item.Cost > 5000;
        }

        /// <summary>
        /// Сравнивает категорию товара с
        /// фиксированной категорией.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        static public bool CompareCategory(Item item)
        {
            return item.Category == Category.Home;
        }

        /// <summary>
        /// Производит фильтрацию списка товаров
        /// по указанному критерию.
        /// </summary>
        /// <param name="items">Товарный объект.</param>
        /// <param name="compare">Критерий сортировки.</param>
        /// <returns>Отфильтрованный список.</returns>
        static public List<Item> Filtering(List<Item> items, Func<Item, bool> compare)
        {
            List<Item> newItems = new List<Item>();

            if (items != null)
            {
                foreach (Item item in items)
                {
                    if (compare(item))
                    {
                        newItems.Add(item);
                    }
                }
            }

            return newItems;
        }

        /// <summary>
        /// Сортирует список товаров по указанному
        /// способу.
        /// </summary>
        /// <param name="items">Товарный объект.</param>
        /// <param name="sortWay">Способ сортировки.</param>
        /// <returns>Отсортированный список.</returns>
        static public List<Item> Sort(List<Item> items, Func<Item, Item, bool> sortWay)
        {
            Item tempItem;

            for (int i = 0; i < items.Count - 1; i++)
            {
                for (int j = i; j < items.Count; j++)
                {
                    if (sortWay(items[i], items[j]))
                    {
                        tempItem = items[i];
                        items[i] = items[j];
                        items[j] = tempItem;
                    }
                }
            }

            return items;
        }
    }
}
