using APIControleFrotas.Models.Infrastructure.Repositories;
using ControleFrotas.Models.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIControleFrotas.Models.Application.Services
{
    public class VeiculoServiceImpl : IVeiculoServico
    {
        private readonly IVeiculoRepositorio veiculoRepositorio;

        public VeiculoServiceImpl(IVeiculoRepositorio veiculoRepositorio)
        {
            this.veiculoRepositorio = veiculoRepositorio;
        }
        public async Task Atualizar(Veiculo veiculo)
        {
            try
            {
                await veiculoRepositorio.Atualizar(veiculo);
            } 
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task Cadastrar(Veiculo veiculo)
        {
            try
            {
                await veiculoRepositorio.Cadastrar(veiculo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Excluir(string veiculoId)
        {
            try
            {
                await veiculoRepositorio.Excluir(veiculoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Veiculo>> Listar()
        {
            try
            {
                return await veiculoRepositorio.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Veiculo>> Listar2()
        {
            try
            {
                return await veiculoRepositorio.Listar2();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Veiculo> Pesquisar(string veiculoId)
        {
            try
            {
               return await veiculoRepositorio.Pesquisar(veiculoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
