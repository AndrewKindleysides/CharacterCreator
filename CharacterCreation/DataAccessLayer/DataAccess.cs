using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters;
using Raven.Client.Document;
using Raven.Client.Linq;

namespace DataAccessLayer
{
    public class DataAccess : IDisposable
    { 
        private readonly DocumentStore _documentStore;
        
        public DataAccess()
        {
            _documentStore = new DocumentStore()
            {
                Url = "http://localhost:8090/",
                DefaultDatabase = "CharacterDatabase"
            };

            _documentStore.Initialize();
        }

        public IRavenQueryable<Character> Load()
        {
            using (var session = _documentStore.OpenSession())
            {
                var characters = session.Query<Character>();
                return characters;
            }
        }

        public IRavenQueryable<Character> Load(string characterName)
        {
            using (var session = _documentStore.OpenSession())
            {
                var character = session.Query<Character>().Where(n=>n.Name == characterName);
                return character;
            }
        }

        public void Save(Character character)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(character);
                session.SaveChanges();
            }
        }
        
        public void Update(Character character)
        {
            using (var session = _documentStore.OpenSession())
            {
                var loadedCharacter = session.Load<Character>(character.Id);
                loadedCharacter.Race.Name = character.Race.Name;
                loadedCharacter.Class.Name = character.Class.Name;
                loadedCharacter.Name = character.Name;
                loadedCharacter.Stamina = character.Stamina;
                loadedCharacter.Crit = character.Crit;
                loadedCharacter.Hit = character.Hit;
                loadedCharacter.Defence = character.Defence;
                session.SaveChanges();
            }
        }

        public void Delete(string characterId)
        {
            using (var session = _documentStore.OpenSession())
            {
                var character = session.Load<Character>(characterId);
                session.Delete(character);
                session.SaveChanges();
            }
        }

        public void Dispose()
        {
            _documentStore.Dispose();
        }
    }
}
