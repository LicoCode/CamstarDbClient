using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Tenda's new NDOs
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class T_NDOs: NamedDataObject
    {
    }
}


