using System.Collections.Generic;

namespace Swashbuckle.TestApp.Models
{
    /// <summary>
    /// Order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Unique identifier of client
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// List of orderlines
        /// </summary>
        public List<OrderLine> OrderLines { get; set; } 
    }
}