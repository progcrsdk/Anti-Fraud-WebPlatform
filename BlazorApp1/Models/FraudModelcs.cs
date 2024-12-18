namespace BlazorApp1.Models
{
    public class FraudModelcs
    {
        public string transactionId { get; set; }
        public decimal amount { get; set; }
        public string cardNumber { get; set; }
        public DateTime date { get; set; } = DateTime.Now; // Значение по умолчанию
        public string location { get; set; }
    }

    public class FraudResponse
    {
        public string apiResponse { get; set; } // Это свойство можно использовать для хранения ответа от API
    }
}
