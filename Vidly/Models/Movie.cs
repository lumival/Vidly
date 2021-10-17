using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    // This class is a plain old CLR object or POCO, which represents the state and behavior of our application
    // in terms of its problem domain. 
    // It doesn't have any behavior or logic, it just has properties which we use for representing state
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // /movies/random
    }
}