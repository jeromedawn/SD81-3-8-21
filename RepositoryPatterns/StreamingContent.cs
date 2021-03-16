using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatterns
{
    public enum MaturityRating { G, PG, TV_Y, TV_G, TV_PG, PG_13, NC_17, TV_14, TV_MA, R }
    public enum GenreType { Horror=1, RomCom, SciFi, TV_G, TV_PG, PG_13, NC_17, TV_14, TV_MA, R }
    public class StreamingContent
    {
        private string v;
        private string v1;
        private MaturityRating r;
        private GenreType horror;
        private double v2;
        private string v3;
        private MaturityRating r1;
        private GenreType horror1;
        private double v3;
        public List<Episodes> Episodes

        public string Title { get; set; }

        public string Description { get; set; }

        public double StarRating { get; set; }

        public MaturityRating MaturityRating { get; set; }

        public GenreType GenreType { get; set; }

        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_Y:
                    case MaturityRating.TV_G:
                    case MaturityRating.TV_PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_14:
                    case MaturityRating.TV_MA:
                    default:
                        return false;

                }
                /*
                if ((int)MaturityRating > 4)
                    return false;
                else
                {
                    return true;
                }
                */
            }
        }
        public StreamingContent(){}

        public StreamingContent(string title, string description, string v, MaturityRating maturityRating, GenreType genreType, double starRating)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            MaturityRating = maturityRating;
            GenreType = genreType;

        }

        public StreamingContent(string v)
        {
            this.v = v;
        }

        public StreamingContent(string v1, MaturityRating r, GenreType horror, double v2)
        {
            this.v1 = v1;
            this.r = r;
            this.horror = horror;
            this.v2 = v2;
        }

        public StreamingContent(string v1, string v3, MaturityRating r1, GenreType horror1, double v3)
        {
            this.v1 = v1;
            this.v3 = v3;
            this.r1 = r1;
            this.horror1 = horror1;
            this.v3 = v3;
        }
    }
}

