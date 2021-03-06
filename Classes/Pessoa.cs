using CadastroPessoa_FS1.interfaces;

namespace CadastroPessoa_FS1.Classes
{
    public abstract class Pessoa : IPessoa
    {

        public string? nome { get; set; }

        public Endereco? endereco { get; set; }
        
        public float rendimento { get; set; }
        
        public abstract float PegarImposto(float rendimento);
    
        public void VerificarPastaArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];
            
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                using (File.Create(caminho)) { }
                
            }

        }
    }
}