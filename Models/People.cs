using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
   public class People  
   {
      public int Id { get; set; }

      [Required()]
      public string Name { get; set; } = null!;

      [Required()]
      [DataType(DataType.Date)]
      public DateTime CreatedAt { get; set; }

      [Required()]
      [DataType(DataType.Time)]
      public TimeSpan TimeAt { get; set; }
   }
}
