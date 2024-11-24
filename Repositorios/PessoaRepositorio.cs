﻿using AplicationTpDB.Data;
using AplicationTpDB.Models;
using AplicationTpDB.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AplicationTpDB.Repositorios
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private readonly AppDbContext _appBbContext;
        public PessoaRepositorio(AppDbContext appDbContext)
        {
            _appBbContext = appDbContext;
        }


        async Task<PessoaModel> IPessoaRepositorio.BuscarPorId(string cpf)
        {
            return await _appBbContext.Pessoa.FirstOrDefaultAsync(x => x.CPF == cpf);
        }

        async Task<List<PessoaModel>> IPessoaRepositorio.BuscarTodasPessoas()
        {
            return await _appBbContext.Pessoa.ToListAsync();
        }

        async Task<PessoaModel> IPessoaRepositorio.AdicionarPessoa(PessoaModel pessoa)
        {
            await _appBbContext.Pessoa.AddAsync(pessoa);
            _appBbContext.SaveChanges();

            return pessoa;
        }

        async Task<bool> IPessoaRepositorio.ApagarPessoa(string cpf)
        {
            PessoaModel pessoaPorId = await BuscarPorId(cpf);

            if (pessoaPorId == null)
            {
                throw new Exception($"Usuario para o ID: {cpf} não encontrado");
            }

            _appBbContext.Pessoa.Remove(pessoaPorId);
            _appBbContext.SaveChanges();

            return true;
        }

        async Task<PessoaModel> IPessoaRepositorio.AtualizarPessoa(PessoaModel pessoa, string cpf)
        {
            PessoaModel pessoaPorId = await BuscarPorId(cpf);

            if (pessoaPorId == null)
            {
                throw new Exception($"Usuario para o CPF: {cpf} não encontrado");
            }

            pessoaPorId.Nome = pessoa.Nome;
            pessoaPorId.CPF = pessoa.CPF;
            pessoaPorId.Genero = pessoa.Genero;
            pessoaPorId.DataNascimento = pessoa.DataNascimento;
            pessoaPorId.CEP = pessoa.CEP;
            pessoaPorId.NumeroEndereco = pessoa.NumeroEndereco;
            pessoaPorId.Rua = pessoa.Nome;
            pessoaPorId.Bairro = pessoa.Nome;

            _appBbContext.Pessoa.Update(pessoaPorId);
            _appBbContext.SaveChanges();

            return pessoaPorId;
        }

    }
}