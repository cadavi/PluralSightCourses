﻿using BethanysPieShop.Models;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Pages.App
{
    public partial class SearchBlazor
    {
        public string SearchText = string.Empty;
        public List<Pie> FilteredPies { get; set; } = new List<Pie>();

        [Inject]
        public IPieRepository? PieRepository { get; set; }

        private void Search()
        {
            FilteredPies.Clear();
            if (PieRepository is not null)
            {
                if (SearchText.Length >= 3)
                    FilteredPies = PieRepository.SearchPies(SearchText).ToList();
            }
        }
    }
}
