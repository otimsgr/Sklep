using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Data.Entities
{
  public class Product
  {
    public int Id { get; set; }
    public string Category { get; set; }
    
    public decimal Price { get; set; }
    public string Title { get; set; }

    public string ArtId { get; set; }
    public string Artist { get; set; }
  
  }
}
