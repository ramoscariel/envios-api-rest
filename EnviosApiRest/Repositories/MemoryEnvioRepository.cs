using EnviosApiRest.Models.Domain;

namespace EnviosApiRest.Repositories
{
    public class MemoryEnvioRepository : IEnvioRepository
    {
        private static readonly List<Envio> envios = new List<Envio>();
        private static int index = 1;

        public async Task<List<Envio>> GetAllAsync()
        {
            return envios;
        }

        public async Task<Envio?> GetByIdAsync(int id)
        {
            var envio = envios.Find(x => x.Id == id);
            return envio;
        }

        public async Task<bool> CreateAsync(Envio envio)
        {
            envio.Id = index++;
            envios.Add(envio);
            return true;
        }
        
    }
}
