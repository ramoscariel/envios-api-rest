using EnviosApiRest.Models.Domain;

namespace EnviosApiRest.Repositories
{
    public interface IEnvioRepository
    {
        public Task<List<Envio>> GetAllAsync();
        public Task<Envio?> GetByIdAsync(int id);
        public Task<bool> CreateAsync (Envio envio);
    }
}
