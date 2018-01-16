namespace Алгоритм_Дейкстры
{
    class Rib
    {
        /// <summary>
        /// Начальная точка
        /// </summary>
        public string FirstPoint { get; set; }
        /// <summary>
        /// Конечная точка
        /// </summary>
        public string SecondPoint { get; set; }
        /// <summary>
        /// Вес ребра
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Создает ребро
        /// </summary>
        /// <param name="fisrtPoint">Начальная точка</param>
        /// <param name="secondPoint">Конечная точка</param>
        /// <param name="weight">Вес ребра</param>
        public Rib(string fisrtPoint, string secondPoint, double weight)
        {
            FirstPoint = fisrtPoint;
            SecondPoint = secondPoint;
            Weight = weight;
        }
        /// <summary>
        /// Проверяет отрицательное ли значени ребра или нет
        /// </summary>
        /// <returns>Возвращает true если значение отрицательное, иначе false</returns>
        public bool IsNegativeMeaning()
        {
            if (Weight < 0)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return FirstPoint + " -> " + SecondPoint + " = " + Weight;
        }
    }
}
