using System;
using System.ComponentModel.DataAnnotations;
namespace PrelloApplication.Models
{
	public class Client
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public string ClientName { get; set; }
        public string EmailAddress { get; set; }

    }
}

