// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Pay.Service.Invoces.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class InvoiceEntity
    {
        /// <summary>
        /// Initializes a new instance of the InvoiceEntity class.
        /// </summary>
        public InvoiceEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InvoiceEntity class.
        /// </summary>
        public InvoiceEntity(double amount, System.DateTime timestamp, string invoiceId = default(string), string invoiceNumber = default(string), string currency = default(string), string clientId = default(string), string clientName = default(string), string clientUserId = default(string), string clientEmail = default(string), string dueDate = default(string), string label = default(string), string status = default(string), string walletAddress = default(string), string partitionKey = default(string), string rowKey = default(string), string eTag = default(string))
        {
            InvoiceId = invoiceId;
            InvoiceNumber = invoiceNumber;
            Amount = amount;
            Currency = currency;
            ClientId = clientId;
            ClientName = clientName;
            ClientUserId = clientUserId;
            ClientEmail = clientEmail;
            DueDate = dueDate;
            Label = label;
            Status = status;
            WalletAddress = walletAddress;
            PartitionKey = partitionKey;
            RowKey = rowKey;
            Timestamp = timestamp;
            ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvoiceId")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvoiceNumber")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public double Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Currency")]
        public string Currency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientName")]
        public string ClientName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientUserId")]
        public string ClientUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientEmail")]
        public string ClientEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DueDate")]
        public string DueDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Label")]
        public string Label { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WalletAddress")]
        public string WalletAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PartitionKey")]
        public string PartitionKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RowKey")]
        public string RowKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Timestamp")]
        public System.DateTime Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
