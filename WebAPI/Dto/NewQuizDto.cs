﻿using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dto;

public class NewQuizDto
{
    [Required]
    [Length(minimumLength: 3, maximumLength: 200)]
    public string Title { get; set; }
    public List<NewQuizItemDto> Items { get; set; } = new List<NewQuizItemDto>();
}