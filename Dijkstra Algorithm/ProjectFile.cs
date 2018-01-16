using System;

namespace Dijkstra_Algorithm
{
    [Serializable]
    class ProjectFile
    {
        public string Names { get; set; }
        public string Weight { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Result { get; set; }
    }
}
