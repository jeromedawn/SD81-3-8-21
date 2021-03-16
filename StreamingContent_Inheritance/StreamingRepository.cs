using RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    class StreamingRepository : StreamingContentRepository

    {
        //Using content directory from StreamingContentRepository.cs

        //Read
        public Show GetShowByTitle(string title)
        {
            //Find a specific show
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;

                }
            }

            return null;
        }

        public Movie GetMovieByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Movie))
                {
                    return (Movie)content;
                }
            }
            return null;

        }

        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if ( content is Show)
                {
                    allShows.Add((Show)content);
                }
            }

            return allShows;

        }
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allMovies.Add((Movie)content);
                }
            }

            return allMovies;

        }
       
    }
}
