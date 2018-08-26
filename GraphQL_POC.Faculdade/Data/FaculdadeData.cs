using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL_POC.Faculdade.Models;

namespace GraphQL_POC.Faculdade.Data
{
    public class FaculdadeData
    {
        private readonly List<Aluno> _alunos = new List<Aluno>();
        private readonly List<Professor> _professores = new List<Professor>();

        public FaculdadeData()
        {
            _alunos.Add(new Aluno
            {
                Cpf = "11111111111",
                Nome = "Felipe",
            });
            _alunos.Add(new Aluno
            {
                Cpf = "11111111112",
                Nome = "Cardozo",
            });
            
            _professores.Add(new Professor
            {
                Cpf = "11111111113",
                Nome = "Allan",
            });
        }
        
        public Task<Aluno> GetAlunoByCpfAsync(string cpf)
        {
            return Task.FromResult(_alunos.FirstOrDefault(a => a.Cpf == cpf));
        }

        public Task<Professor> GetProfessorByCpfAsync(string cpf)
        {
            return Task.FromResult(_professores.FirstOrDefault(p => p.Cpf == cpf));
        }

        public Aluno AddAluno(Aluno aluno)
        {
            aluno.Cpf = Guid.NewGuid().ToString();
            _alunos.Add(aluno);
            return aluno;
        }
    }
}