using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lahoz.Core
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
