using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF.Models
{
  
        public class Job
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string Name { get; set; }
            public int Userid { get; set; }
            
             [ForeignKey("Userid")]
            public virtual User? User { get; set; }
        }
    
}
