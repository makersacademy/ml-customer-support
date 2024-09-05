namespace SupportApp.Models
{
    public class SupportRequest
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty; // Initialize with default value
        public string Description { get; set; } = string.Empty; // Initialize with default value
        public bool IsResolved { get; set; } // Add this property
        public string? Notes { get; set; }
    }
}