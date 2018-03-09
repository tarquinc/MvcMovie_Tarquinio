using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie_Tarquinio.Models
{
    public class ReviewList
    {
        public Movie movie { get; set; }
        public SelectList mReview;
        public List<Reviews> review { get; set; }

    }
}
