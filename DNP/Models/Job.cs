using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Models
{
    public class Job
    {
       public string JobTitle { get; set; }
        public int Salary { get; set; }
        
        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }
        
        
        
        
        
    }
}