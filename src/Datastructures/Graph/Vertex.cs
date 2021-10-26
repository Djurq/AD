using System;
using System.Collections.Generic;
using System.Linq;


namespace AD
{
    public partial class Vertex : IVertex
    {
        public string name;
        public LinkedList<Edge> adj;
        public double distance;
        public Vertex prev;
        public bool known;


        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------

        /// <summary>
        ///    Creates a new Vertex instance.
        /// </summary>
        /// <param name="name">The name of the new vertex</param>
        public Vertex(string name)
        {
            this.name = name;
            adj = new LinkedList<Edge>();
            Reset();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public string GetName()
        {
            return name;
        }
        public LinkedList<Edge> GetAdjacents()
        {
            return adj;
        }

        public double GetDistance()
        {
            return distance;
        }

        public Vertex GetPrevious()
        {
            return prev;
        }

        public bool GetKnown()
        {
            return known;
        }

        public void Reset()
        {
            distance = Graph.INFINITY;
            prev = null;
            known = false;
        }


        //----------------------------------------------------------------------
        // ToString that has to be implemented for exam
        //----------------------------------------------------------------------

        /// <summary>
        ///    Converts this instance of Vertex to its string representation.
        ///    <para>Output will be like : name (distance) [ adj1 (cost) adj2 (cost) .. ]</para>
        ///    <para>Adjecents are ordered ascending by name. If no distance is
        ///    calculated yet, the distance and the parantheses are omitted.</para>
        /// </summary>
        /// <returns>The string representation of this Graph instance</returns> 
        public override string ToString()
        {
            string vertexString = "";
            vertexString += name;
            if (Math.Abs(GetDistance() - Graph.INFINITY) > 1)
            {
              vertexString += " (" + distance + ")" + " [";
            }
            else
            {
                vertexString += " [";
            }
            
            foreach (Edge e in adj.OrderBy(x => x.dest.name))
            {
                vertexString += e.dest.name + " (" + e.cost + ") ";
            }

            return vertexString + " ]";
        }
    }
}