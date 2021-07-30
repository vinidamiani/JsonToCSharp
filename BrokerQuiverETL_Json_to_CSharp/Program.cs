using System;
using System.Collections.Generic;
using System.Text.Json;

namespace DeserializeExtra
{
        public class TETMLParameters
        {
            public string mode { get; set; }
        }

        public class PDF2TXTParameters
        {
            public string mode { get; set; }
        }

        public class TabulaParameters
        {
            public string mode { get; set; }
        }

        public class ParametrosProcessadores
        {
            public TETMLParameters TETMLParameters { get; set; }
            public PDF2TXTParameters PDF2TXTParameters { get; set; }
            public TabulaParameters TabulaParameters { get; set; }
        }

        public class AtributosDeExtracao
        {
            public string NomeAtributo { get; set; }
            public int OrdemProcessamento { get; set; }
            public int TipoDoAtributoDeSaida { get; set; }
            public int OrigemDaEntrada { get; set; }
            public string NomeDaOrigemDaEntrada { get; set; }
            public string AssociarAtributoDoSchema { get; set; }
            public object Chave { get; set; }
            public object ChaveSuperior { get; set; }
            public int Processador { get; set; }
            public string ModoProcessador { get; set; }
            public object AtibutosAdicionaisModoProcessador { get; set; }
            public string ParametrosDeExtracaoDoAtributo { get; set; }
            public string ParametrosTabela { get; set; }
            public string NormalizacaoId { get; set; }
            public int TipoCondicao { get; set; }
            public string ValorCondicao { get; set; }
            public int TipoCondicao2 { get; set; }
            public string ValorCondicao2 { get; set; }
            public int TipoCondicao3 { get; set; }
            public string ValorCondicao3 { get; set; }
            public bool IsDeleted { get; set; }
            public object DeleterUserId { get; set; }
            public object DeletionTime { get; set; }
            public DateTimeOffset LastModificationTime { get; set; }
            public int LastModifierUserId { get; set; }
            public DateTimeOffset CreationTime { get; set; }
            public object CreatorUserId { get; set; }
            public int Id { get; set; }
        }

        public class Root
        {
            public int Seguradora { get; set; }
            public int Ramo { get; set; }
            public int TipoDocumento { get; set; }
            public string Versao { get; set; }
            public int TipoCondicao { get; set; }
            public string ValorCondicao { get; set; }
            public int TipoCondicao2 { get; set; }
            public string ValorCondicao2 { get; set; }
            public int TipoCondicao3 { get; set; }
            public string ValorCondicao3 { get; set; }
            public string ObjectId { get; set; }
            public string ProcessamentoAdicional { get; set; }
            public ParametrosProcessadores ParametrosProcessadores { get; set; }
            public List<AtributosDeExtracao> AtributosDeExtracao { get; set; }
            public List<object> ArquivosExemplo { get; set; }
            public bool IsDeleted { get; set; }
            public object DeleterUserId { get; set; }
            public object DeletionTime { get; set; }
            public DateTimeOffset LastModificationTime { get; set; }
            public int LastModifierUserId { get; set; }
            public DateTimeOffset CreationTime { get; set; }
            public int CreatorUserId { get; set; }
        }


    public class Program
    {
        public static void Main()
        {

            string jsonString = System.IO.File.ReadAllText(@"C:\JsonToCSharp\QuiverETLJsons\PROPOSTA_MAPFRE_VEICULO_AUTOMAIS.json");


            Root etl = JsonSerializer.Deserialize<Root>(jsonString);

            Console.WriteLine($"DeleterUserId: {etl.DeleterUserId}");
        }
    }
}