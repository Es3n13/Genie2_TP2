using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using Genie2_TP2.Models;

namespace Genie2_TP2.ViewModels
{
    public class FilmSearchViewModel
    {
        public ObservableCollection<FilmModel> Films { get; set; }

        public FilmSearchViewModel()
        {
            // Films de test
            Films = new ObservableCollection<FilmModel>
            {
                new FilmModel
                {
                    Title = "Inception",
                    Year = 2010,
                    Rating = 5,
                    Poster = "pack://application:,,,/images/Inception.jpg",
                    Description = "Un voleur qui s'introduit dans les rêves..."
                },
                new FilmModel
                {
                    Title = "The Matrix",
                    Year = 1999,
                    Rating = 5,
                    Poster = "pack://application:,,,/images/Matrix.jpg",
                    Description = "Un hacker découvre la réalité..."
                },
                new FilmModel
                {
                    Title = "Interstellar",
                    Year = 2014,
                    Rating = 4,
                    Poster = "/images/Interstellar.jpg",
                    Description = "Des explorateurs voyagent à travers l'espace..."
                },
                new FilmModel
                {
                    Title = "Avatar",
                    Year = 2009,
                    Rating = 4,
                    Poster = "pack://application:,,,/images/Avatar.jpg",
                    Description = "Des humains débarque sur une nouvelle planète..."
                }
            };
        }
    }
}
