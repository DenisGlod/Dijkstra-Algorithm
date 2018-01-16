using System.Collections.Generic;
using System.Text;

namespace Dijkstra_Algorithm
{
    class Point
    {
        /// <summary>
        /// Название вершины
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Расстояние до вершины
        /// </summary>
        public double Value { get; set; }
        /// <summary>
        /// Путь до вершины по меткам
        /// </summary>
        public List<string> Path { get; set; }
        /// <summary>
        /// Исспользовалась ли вершина
        /// </summary>
        public int Check { get; set; }

        /// <summary>
        /// Создает объект Point без параметров
        /// </summary>
        public Point()
        {
            Path = new List<string>();
            Check = -1;
        }
        /// <summary>
        /// Создает объект Point
        /// </summary>
        /// <param name="name">Название вершины</param>
        public Point(string name)
        {
            Path = new List<string>();
            Name = name;
            Check = -1;
        }
        /// <summary>
        /// Создает объект Point
        /// </summary>
        /// <param name="name">Название вершины</param>
        /// <param name="value">Расстояние до вершины</param>
        public Point(string name, double value)
        {
            Path = new List<string>();
            Name = name;
            Value = value;
            Check = -1;
        }
        /// <summary>
        /// Создает объект Point
        /// </summary>
        /// <param name="name">Название вршины</param>
        /// <param name="value">Расстояние до вершины</param>
        /// <param name="check">Исспользовалась ли вершина</param>
        public Point(string name, double value, int check)
        {
            Path = new List<string>();
            Name = name;
            Value = value;
            Check = check;
        }
        /// <summary>
        /// Создает объект Point
        /// </summary>
        /// <param name="name">Название вршины</param>
        /// <param name="value">Расстояние до вершины</param>
        /// <param name="path">Путь до вершины по меткам</param>
        /// <param name="check">Исспользовалась ли вершина</param>
        public Point(string name, double value, List<string> path, int check)
        {
            Name = name;
            Value = value;
            Path = path;
            Check = check;
        }

        /// <summary>
        /// Возвращает путь до этой точки в виде строки
        /// </summary>
        /// <returns>Возвращает строку</returns>
        public string GetPathToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Path.Count; i++)
            {
                if (i == Path.Count - 1)
                {
                    sb.Append(Path[i]);
                    continue;
                }
                sb.Append(Path[i]).Append(" -> ");
            }
            return sb.ToString();
        }
    }
}
