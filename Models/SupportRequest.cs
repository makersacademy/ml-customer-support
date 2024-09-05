using SupportApp.Enums;

namespace SupportApp.Models
{
    public class SupportRequest
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty; // Initialize with default value
        public string Description { get; set; } = string.Empty; // Initialize with default value
        public bool IsResolved { get; set; } // Add this property
        public Urgency Urgency { get; set; }
        public string UrgencyIcon { get {
            return Urgency switch
                {
                    Urgency.Low =>  "&#128681;",
                    Urgency.Medium => "&#128679;",
                    Urgency.High => "&#128680;",
                    Urgency.Apocolypse => "&#127755;",
                    _ => "&#128681;",
                };
            }
        }
    }
}