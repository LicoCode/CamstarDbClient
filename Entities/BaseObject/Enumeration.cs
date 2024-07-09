using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CamstarDb.Entities
{
    ///    @Description Base CDO for the Enumeration Type CDOs
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class Enumeration : BaseObject
    {
    }
}


