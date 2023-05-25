namespace MVC_Trabalho.Model
{
    public class Evento
    {
        public int Data { get; set; }

        public string? Nome { get; set; }

        public String? Descricao { get; set; }

        private const string PATH = "Database/Evento.csv";


        public Evento()
        {
            
            string pasta = PATH.Split("/")[0];

            
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
           

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Evento> Ler()
        {
            List<Evento> Eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Evento e = new Evento();

                e.Data = int.Parse(atributos[0]);
                e.Nome = atributos[1];
                e.Descricao = atributos[2];

                Eventos.Add(e);

            }
            return Eventos;
        }

        public string PrepararLinhasCSV(Evento e)
        {
            return $"{e.Data};{e.Nome};{e.Descricao}";
        }

        public void Inserir(Evento e)
        {
            string[] linhas = { PrepararLinhasCSV(e) };

            File.AppendAllLines(PATH, linhas);
        }
    }
}