using CadastroPessoa_FS1.interfaces;

namespace CadastroPessoa_FS1.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica       
    {

        public string ?cpf { get; set; }        

        public string ?dataNascimento { get; set; }
        
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }           
              
            return false;   
        }

        public bool ValidarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {

                // Console.WriteLine($"{dataConvertida}");

                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }           
                
                return false;                     
            }
            return false;
        }

        public override float PegarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}