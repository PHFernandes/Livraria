using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Entities
{
    public enum EnumStatusProjeto
    {
        [Display(Name = "Aguardando Aprovação")]
        [Description("Aguardando Aprovação")]
        AguardandoAprovacao = 1,

        [Display(Name = "Em Execução")]
        [Description("Em Execução")]
        EmExecucao = 2,

        [Display(Name = "Entregue")]
        [Description("Entregue")]
        Entregue = 3,

        [Display(Name = "Concluído")]
        [Description("Concluído")]
        Concluido = 4,

        [Display(Name = "Atrasado")]
        [Description("Atrasado")]
        Atrasado = 5,

        [Display(Name = "Paralisado")]
        [Description("Paralisado")]
        Paralisado = 6
    }

    public enum EnumTipoIndicador
    {
        [Display(Name = "Inteiro")]
        [Description("Inteiro")]
        Int = 1,

        [Display(Name = "Texto")]
        [Description("Texto")]
        Varchar = 2,

        [Display(Name = "Decimal")]
        [Description("Decimal")]
        Decimal = 3,

        [Display(Name = "Data")]
        [Description("Data")]
        DateTime = 4,

        [Display(Name = "Entidade")]
        [Description("Entidade")]
        Entity = 5
    }
}