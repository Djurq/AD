using System;
using System.Collections.Generic;
using System.Linq;


namespace AD
{
    public partial class Graph : IGraph
    {
        public static readonly double INFINITY = System.Double.MaxValue;

        public Dictionary<string, Vertex> vertexMap;


        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------

        public Graph()
        {
            vertexMap = new Dictionary<string, Vertex>();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        /// <summary>
        ///    Adds a vertex to the graph. If a vertex with the given name
        ///    already exists, no action is performed.
        /// </summary>
        /// <param name="name">The name of the new vertex</param>
        public void AddVertex(string name)
        {
            GetVertex(name);
        }


        /// <summary>
        ///    Gets a vertex from the graph by name. If no such vertex exists,
        ///    a new vertex will be created and returned.
        /// </summary>
        /// <param name="name">The name of the vertex</param>
        /// <returns>The vertex withe the given name</returns>
        public Vertex GetVertex(string name)
        {
            if (vertexMap.ContainsKey(name)) return vertexMap[name];
            Vertex vertex = new Vertex(name);
            vertexMap.Add(name, vertex);
            return vertex;
        }


        /// <summary>
        ///    Creates an edge between two vertices. Vertices that are non existing
        ///    will be created before adding the edge.
        ///    There is no check on multiple edges!
        /// </summary>
        /// <param name="source">The name of the source vertex</param>
        /// <param name="dest">The name of the destination vertex</param>
        /// <param name="cost">cost of the edge</param>
        public void AddEdge(string source, string dest, double cost = 1)
        {
            Vertex vSourve = GetVertex(source);
            Vertex vDest = GetVertex(dest);
            vSourve.adj.AddFirst(new Edge(vDest, cost));
        }


        /// <summary>
        ///    Clears all info within the vertices. This method will not remove any
        ///    vertices or edges.
        /// </summary>
        public void ClearAll()
        {
            foreach (var vertex in vertexMap.Values)
            {
                vertex.Reset();
            }
        }

        /// <summary>
        ///    Performs the Breatch-First algorithm for unweighted graphs.
        /// </summary>
        /// <param name="name">The name of the starting vertex</param>
        public void Unweighted(string name)
        {
            ClearAll();

            Queue<Vertex> queue = new Queue<Vertex>();
            Vertex start = GetVertex(name);
            
            queue.Enqueue(start);
            start.distance = 0;
            start.known = true;
            
            while (queue.Count > 0)
            {
                Vertex vertex = queue.Dequeue();
                foreach (Edge edge in vertex.adj)
                {
                    Vertex dest = edge.dest;
                    dest.distance = Math.Min(vertex.distance + 1, dest.distance);
                    if (!dest.known)
                    {
                        dest.known = true;
                        dest.prev = vertex;
                        queue.Enqueue(dest);
                    }
                }
            }
        }

        /// <summary>
        ///    Performs the Dijkstra algorithm for weighted graphs.
        /// </summary>
        /// <param name="name">The name of the starting vertex</param>
        public void Dijkstra(string name)
        {
            throw new System.NotImplementedException();
        }

        //----------------------------------------------------------------------
        // ToString that has to be implemented for exam
        //----------------------------------------------------------------------

        /// <summary>
        ///    Converts this instance of Graph to its string representation.
        ///    It will call the ToString method of each Vertex. The output is
        ///    ascending on vertex name.
        /// </summary>
        /// <returns>The string representation of this Graph instance</returns>
        public override string ToString()
        {
            string graphString = "";
            foreach (string key in vertexMap.Keys.OrderBy(x => x))
            {
                graphString += vertexMap[key] + "\n";
                Console.WriteLine(vertexMap[key].name + " " + vertexMap[key].distance);
            }

            return graphString;
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------



        public bool IsConnected()
        {
            throw new System.NotImplementedException();
        }

    }
}