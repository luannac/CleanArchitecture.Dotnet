using Core.Entities.Base;

namespace Core.Entities
{
    public class Movie : Entity
    {
        public string MovieName {get;set;}
        public string DirectoryName { get; set;}
        public string ReleaseYear { get; set;}
    }
}