using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description NamedObjectGroup is used to provide a list of named object.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public class NamedObjectGroup : ObjectGroup
    {
    }
}

