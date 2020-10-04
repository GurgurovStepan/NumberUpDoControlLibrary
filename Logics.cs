using System.Net;
using System.Windows.Converters;
using System.Windows.Data;

namespace NumberUpDoControlLibrary
{
    class Logics
    {
        /// <summary>
        /// Текущее значение
        /// </summary>
        private int curentValue;
        /// <summary>
        /// максимальное значение
        /// </summary>
        private readonly int maxValue = 100;
        /// <summary>
        /// минимальное значение
        /// </summary>
        private readonly int minValue = -100;
        /// <summary>
        /// Текущее значение
        /// </summary>
        public int Value 
        {
            get 
            {
                if (curentValue > maxValue)
                    return maxValue;

                if (curentValue < minValue)
                    return minValue; 
                
                return curentValue;

            }
            protected set { curentValue = value; }
        }
        /// <summary>
        /// Увеличить текущее значение
        /// </summary>
        public int UpValue
        {
            get
            { 
                Value += 5;
                return Value;
            }
        }
       /// <summary>
       /// уменьшить текущее значение
       /// </summary>
        public int DownValue
        {
            get 
            { 
                Value -= 5;
                return Value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Logics() 
        { 
            Value = 0; 
        }
        
    }
}
