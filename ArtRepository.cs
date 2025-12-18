using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLib
{
    public class ArtRepository
    {

        public List<Art> arts;
        public int nextId = 1;

        public ArtRepository()
        {
            arts = new List<Art>();

            Add(new Art { ArtName = "Mona Lisa", ArtType = "Painting", Price = 1000000 });
            Add(new Art { ArtName = "The Thinker", ArtType = "Sculpture", Price = 500000 });
            Add(new Art { ArtName = "Starry Night", ArtType = "Painting", Price = 750000 });
            Add(new Art { ArtName = "The Kiss", ArtType = "Painting", Price = 600000 });
        }

        public void Add(Art art)
        {
            art.Id = nextId;
            nextId++;
            arts.Add(art);
        }

        public List<Art> GetAll()
        {

            return new List<Art>(arts);
        }

        public Art GetById(int id)
        {
            foreach (var art in arts)
            {
                if (art.Id == id)
                {
                    return (Art) art;
                }                
            }
            return null;
        }

        public Art? DeleteArt(int id)
        {

            Art artToRemove = GetById(id);

            if (artToRemove == null)
            {
                return null;
            }
            arts.Remove(artToRemove);
            return artToRemove;
        }

    }
}
