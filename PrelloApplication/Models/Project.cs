﻿using System;
using System.ComponentModel.DataAnnotations;
namespace PrelloApplication.Models
{
	public class Project
	{
		[Key]
		public int Id { get; set; }
		[Required]
        public string ProjectName { get; set; }
		public DateTime DateDue { get; set; }
		public string Description { get; set; }
        public string Status { get; set; }
	}
}

// dependencies
	// Sqlite
	// microsoftEntityFrameworkCore
	// Tools
	// Design