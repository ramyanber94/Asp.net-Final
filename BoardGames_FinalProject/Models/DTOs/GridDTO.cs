﻿namespace BoardGames_FinalProject.Models.DTOs
{
    public class GridDTO
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 4;
        public string SortField { get; set; }
        public string SortDirection { get; set; } = "asc";
    }
}
