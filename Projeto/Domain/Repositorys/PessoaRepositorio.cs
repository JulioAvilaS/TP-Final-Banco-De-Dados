using AplicationTpDB.Data;
using AplicationTpDB.Interface.Repository;
using AplicationTpDB.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicationTpDB.Domain.Repositorios
{
    public class PessoaRepositorio : IPessoaRepository
    {
        private readonly AppDbContext _appDbContext;

        public PessoaRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        async Task<PessoaModel> IPessoaRepository.BuscarPorId(string cpf)
        {
            return await _appDbContext.Pessoa.FirstOrDefaultAsync(x => x.CPF == cpf);
        }

        async Task<List<PessoaModel>> IPessoaRepository.BuscarTodasPessoas()
        {
            return await _appDbContext.Pessoa.ToListAsync();
        }

        async Task<PessoaModel> IPessoaRepository.AdicionarPessoa(PessoaModel pessoa)
        {
            await _appDbContext.Pessoa.AddAsync(pessoa);
            await _appDbContext.SaveChangesAsync();
            return pessoa;
        }

        async Task<bool> IPessoaRepository.ApagarPessoa(string cpf)
        {
            PessoaModel pessoaPorId = await ((IPessoaRepository)this).BuscarPorId(cpf);

            if (pessoaPorId == null)
            {
                throw new Exception($"Usuário com CPF: {cpf} não encontrado");
            }

            _appDbContext.Pessoa.Remove(pessoaPorId);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        async Task<PessoaModel> IPessoaRepository.AtualizarPessoa(PessoaModel pessoa, string cpf)
        {
            PessoaModel pessoaPorId = await ((IPessoaRepository)this).BuscarPorId(cpf);

            if (pessoaPorId == null)
            {
                throw new Exception($"Usuário com CPF: {cpf} não encontrado");
            }

            pessoaPorId.Nome = pessoa.Nome;
            pessoaPorId.CPF = pessoa.CPF;
            pessoaPorId.Genero = pessoa.Genero;
            pessoaPorId.DataNascimento = pessoa.DataNascimento;
            pessoaPorId.CEP = pessoa.CEP;
            pessoaPorId.NumeroEndereco = pessoa.NumeroEndereco;
            pessoaPorId.Rua = pessoa.Rua;
            pessoaPorId.Bairro = pessoa.Bairro;

            _appDbContext.Pessoa.Update(pessoaPorId);
            await _appDbContext.SaveChangesAsync();

            return pessoaPorId;
        }

        public Task<PessoaModel> ApagarPessoa(string id)
        {
            throw new NotImplementedException();
        }
    }
}
